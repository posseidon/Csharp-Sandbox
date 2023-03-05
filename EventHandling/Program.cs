using EventHandling;

Publisher p = new();
Subscriber receiver = new();
p.ArgumentChanged += receiver.EventObserver;
Console.WriteLine("Type in your password: ...");
while (true)
{
    p.CheckPassword(Console.ReadLine());
}

