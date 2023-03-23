using Microsoft.Graphics.Canvas;
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.Gaming.Input;
using Windows.UI;

namespace XAMLAnimatedCanvasPong
{
    public interface IDrawable
    {
        void Draw(CanvasDrawingSession canvas);
    }

    public interface ICollidable
    {
        bool CollidesLeftEdge(int x, int y);
        bool ColllidesRightEdge(int x, int y);
        bool CollidesTopEdge(int x, int y);
        bool CoolidesBottomEdge(int x, int y);
    }

    public interface IDestroyable : ICollidable
    { }


    public class Pong
    {
        public static int LEFT_EDGE = 10;
        public static int TOP_EDGE = 10;
        public static int RIGHT_EDGE = 790;
        public static int BOTTOM_EDGE = 450;

        private Random random;

        private Ball ball;
        private Paddle ComputerPaddle;
        private Paddle PlayerPaddle;
        private List<IDrawable> drawables;
        private bool gameOver;

        private Gamepad controller;

        public Pong(CanvasBitmap ballImage)
        {

            drawables = new List<IDrawable>();

            ball = new Ball(100, 100, ballImage);
            drawables.Add(ball);
            ball.TravelingDownward = true;
            ball.TravelingLeftward = true;

            var leftWall = new Wall(LEFT_EDGE, TOP_EDGE, LEFT_EDGE, BOTTOM_EDGE, Colors.White);
            drawables.Add(leftWall);

            var rightWall = new Wall(RIGHT_EDGE, TOP_EDGE, RIGHT_EDGE, BOTTOM_EDGE, Colors.White);
            drawables.Add(rightWall);

            PlayerPaddle = new Paddle(LEFT_EDGE + RIGHT_EDGE / 2, BOTTOM_EDGE, 50, 5, Colors.White);
            ComputerPaddle = new Paddle(LEFT_EDGE + RIGHT_EDGE / 2, TOP_EDGE, 50, 5, Colors.White);

            drawables.Add(PlayerPaddle);
            drawables.Add(ComputerPaddle);

            gameOver = false;

            random = new Random();
        }

        public void SetPaddleTravelingLeftward(bool travelingLeftward)
        {
            PlayerPaddle.TravelingLeftward = travelingLeftward;
        }

        public void SetPaddleTravelingRightward(bool travelingRightward)
        {
            PlayerPaddle.TravelingRightward = travelingRightward;
        }

        public bool Update()
        {
            bool bounced = false;

            if (Gamepad.Gamepads.Count > 0)
            {
                controller = Gamepad.Gamepads.First();
                var reading = controller.GetCurrentReading();
                PlayerPaddle.X += (int)(reading.LeftThumbstickX * 5);
                PlayerPaddle.Y += (int)(reading.LeftThumbstickY * -5);

                if (reading.Buttons.HasFlag(GamepadButtons.A) )
                    {
                    var obstacle = new Brick(random.Next(LEFT_EDGE + 50, RIGHT_EDGE - 50),
                        random.Next(TOP_EDGE + 50, BOTTOM_EDGE - 50), 
                        random.Next(5, 50), 
                        random.Next(5, 10), 
                        PickRandomColor());
                    drawables.Add(obstacle);
                }
            }

            if (!gameOver)
            {
                List<IDrawable> bricksToDestroy = new List<IDrawable>();
                foreach (var drawable in drawables)
                {
                    ICollidable colliable = drawable as ICollidable;
                    if (colliable != null)
                    {
                        if (colliable.CoolidesBottomEdge(ball.X, ball.Y))
                        {
                            ball.TravelingDownward = !ball.TravelingDownward;
                            ball.ChangeColorRandomly();
                            bounced = true;
                        }
                        else if (colliable.CollidesTopEdge(ball.X, ball.Y + ball.Radius * 2))
                        {
                            ball.TravelingDownward = !ball.TravelingDownward;
                            ball.ChangeColorRandomly();
                            bounced = true;
                        }
                        else if (colliable.CollidesLeftEdge(ball.X, ball.Y))
                        {
                            ball.TravelingLeftward = !ball.TravelingLeftward;
                            ball.ChangeColorRandomly();
                            bounced = true;
                        }
                        else if (colliable.ColllidesRightEdge(ball.X + ball.Radius * 2, ball.Y))
                        {
                            ball.TravelingLeftward = !ball.TravelingLeftward;
                            ball.ChangeColorRandomly();
                            bounced = true;
                        }

                        if ( bounced )
                        {
                            IDestroyable brick = colliable as IDestroyable;
                            if ( brick != null )
                            {
                                bricksToDestroy.Add(brick as IDrawable);
                            }
                        }
                    }

                }
                foreach( var brick in bricksToDestroy)
                {
                    drawables.Remove(brick);
                }

                ball.Update();
                PlayerPaddle.Update();
                ComputerPaddle.X = ball.X - ComputerPaddle.Width / 2;

                gameOver = ball.Y < TOP_EDGE || ball.Y > BOTTOM_EDGE;
            }

            return bounced;
        }


        public void DrawGame(CanvasDrawingSession canvas)
        {
            foreach (var drawable in drawables)
            {
                drawable.Draw(canvas);
            }
        }

        public Color PickRandomColor()
        {
            Random random = new Random();
            return Color.FromArgb(255, (byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256));
        }
    }

    public class Ball : IDrawable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }

        public Color Color { get; set; }
        public bool TravelingDownward { get; set; }
        public bool TravelingLeftward { get; set; }
        private CanvasBitmap image;

        public Ball(int x, int y, CanvasBitmap image)
        {
            X = x;
            Y = y;
            Radius = (int)image.Size.Height;
            this.image = image;
        }

        public void Update()
        {
            if (TravelingDownward)
            {
                Y += 1;
            }
            else
            {
                Y -= 1;
            }
            if (TravelingLeftward)
            {
                X -= 1;
            }
            else
            {
                X += 1;
            }
        }

        public void ChangeColorRandomly()
        {
            Random random = new Random();
            Color = Color.FromArgb(255, (byte)random.Next(0, 256), (byte)random.Next(0, 256), (byte)random.Next(0, 256));
        }

        public void Draw(CanvasDrawingSession canvas)
        {
            canvas.DrawImage(image, X, Y);
            //canvas.DrawEllipse(X, Y, Radius, Radius, image);
        }
    }

    public class Wall : IDrawable, ICollidable
    {
        public static int WIDTH = 3;
        public int X0 { get; set; }
        public int Y0 { get; set; }
        public int X1 { get; set; }

        public int Y1 { get; set; }

        public Color Color { get; set; }

        public Wall(int x0, int y0, int x1, int y1, Color color)
        {
            X0 = x0;
            Y0 = y0;
            X1 = x1;
            Y1 = y1;
            Color = color;
        }


        public void Draw(CanvasDrawingSession canvas)
        {
            canvas.DrawLine(X0, Y0, X1, Y1, Color, WIDTH);
        }

        public bool CollidesLeftEdge(int x, int y)
        {
            return x == X0 && y >= Y0 && y <= Y1;
        }

        public bool ColllidesRightEdge(int x, int y)
        {
            return x == X1 + WIDTH && y >= Y0 && y <= Y1;
        }

        public bool CollidesTopEdge(int x, int y)
        {
            return x >= X0 && x <= X1 && y == Y1;
        }

        public bool CoolidesBottomEdge(int x, int y)
        {
            return x >= X0 && x <= X1 && y + WIDTH == Y0;
        }
    }

    public class Paddle : IDrawable, ICollidable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }

        public int Height { get; set; }

        public Color Color { get; set; }

        public bool TravelingLeftward { get; set; }
        public bool TravelingRightward { get; set; }

        public Paddle(int x, int y, int width, int height, Color color)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Color = color;
            TravelingLeftward = false;
            TravelingRightward = false;
        }

        public void Update()
        {
            if (TravelingRightward)
            {
                X += 1;
            }
            else if (TravelingLeftward)
            {
                X -= 1;
            }
        }


        public void Draw(CanvasDrawingSession canvas)
        {
            canvas.DrawRectangle(X, Y, Width, Height, Color, 3);
        }

        public bool CollidesLeftEdge(int x, int y)
        {
            return x >= X && x <= X + Width && y >= Y && y <= Y + Height;
        }

        public bool ColllidesRightEdge(int x, int y)
        {
            return x >= X && x <= X + Width && y >= Y && y <= Y + Height;
        }

        public bool CollidesTopEdge(int x, int y)
        {
            return x >= X && x <= X + Width && y >= Y && y <= Y + Height;
        }

        public bool CoolidesBottomEdge(int x, int y)
        {
            return x >= X && x <= X + Width && y >= Y && y <= Y + Height;
        }
    }

    public class Brick : Paddle, IDestroyable
    {
        public Brick(int x, int y, int width, int height, Color color) : base(x, y, width, height, color)
        {

        }
    }

}
