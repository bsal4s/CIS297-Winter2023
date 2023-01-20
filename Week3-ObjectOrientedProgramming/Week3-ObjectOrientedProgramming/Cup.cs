using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_ObjectOrientedProgramming
{
    public class Cup
    {
        // property

        // the property is set only in the class
        public string Color { get; private set; }
        public string Contents { get; set; }
        // try not to set values here
        // private int volumeInMilliliters = 0;
        private int volumeInMilliliters;

        // constuctors job is to give values to attributes
        // nulls make us sad and crash programs
        //public Cup()
        //{
        //    color = string.Empty;
        //    contents = string.Empty;
        //    volumeInMilliliters = 0;
        //}

        // defaults for parameters make them optional
        public Cup(string color, string contents = "", int volumeInMilliliters = 0)
        {
            this.Color = color;
            this.Contents = contents;
            this.volumeInMilliliters = volumeInMilliliters;
        }

        public bool drink(int millitliersToDrink)
        {
            if ( millitliersToDrink > volumeInMilliliters)
            {
                return false;
            }
            volumeInMilliliters -= millitliersToDrink;
            return true;
        }

        public int getVolumeInMilliliters()
        {
            return volumeInMilliliters;
        }

        public void setVolumeInMilliliters(int volumeInMilliliters)
        {
            if (volumeInMilliliters <= 0)
            {
                volumeInMilliliters = 0;
            }
            this.volumeInMilliliters = volumeInMilliliters;

        }

        //public string getColor()
        //{
        //    return color;
        //}

        //public void setColor(string color)
        //{
        //    this.color = color;
        //}

        //public string getContents()
        //{
        //    return contents;
        //}

        //public void setContents(string contents)
        //{
        //    this.contents = contents;
        //}
    }
}
