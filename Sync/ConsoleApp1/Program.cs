using System;
using System.Threading;


var manualEvent = new EventWaitHandle(true, EventResetMode.ManualReset, "Global\\MyAppEvent");
var manualEvent1 = new EventWaitHandle(false, EventResetMode.ManualReset, "Global\\MyAppEven1");

for (int i = 0; i <= 10; i+=2)
{
    manualEvent.WaitOne();
    manualEvent.Reset(); 
    Console.WriteLine(i);
    Thread.Sleep(1000);
    manualEvent1.Set();
}