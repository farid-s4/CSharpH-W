using System;
using System.Threading;

var manualEvent = new EventWaitHandle(false, EventResetMode.ManualReset, "Global\\MyAppEvent");
var manualEvent1 = new EventWaitHandle(false, EventResetMode.ManualReset, "Global\\MyAppEven1");


for (int i = 1; i <= 10; i+=2)
{
    manualEvent1.WaitOne();
    manualEvent1.Reset(); 
    Console.WriteLine(i);
    Thread.Sleep(1000);
    manualEvent.Set();
}