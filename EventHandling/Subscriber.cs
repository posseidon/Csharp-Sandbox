namespace EventHandling
{
    class Subscriber
    {
        public void EventObserver(ParameterChangedEventArgs e)
        {
            Console.WriteLine("Password match: " + e.StrParameter);
        }
    }
}
