// See https://aka.ms/new-console-template for more information
using Week7_Async;

Console.WriteLine("Hello, World!");

int number = 0;
// DANGER ZONE
int currentCount = 0;



void CountTo1_000()
{
    // currentCount is NOT THREAD SAFE
    int currentNumber = number++;
    int currentCount = 0;
    while (currentCount < 1_000)
    {
        currentCount = SharedNumber.GetNumber();
        Console.WriteLine($"thread {currentNumber} current count {currentCount}");
    }
}

Thread thread = new Thread(CountTo1_000);
thread.Start();
Thread thread2 = new Thread(CountTo1_000);
thread2.Start();
Thread thread3 = new Thread(CountTo1_000);
thread3.Start();
Console.WriteLine("Thread Started");
Console.WriteLine("Doing more work!");
for(int i = 1000; i>0; i--)
{
    Console.WriteLine($"main {i}");
}
thread.Join(); // waits until the thread is done
Console.WriteLine("All done!");