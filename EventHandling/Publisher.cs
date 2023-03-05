namespace EventHandling
{
    public delegate void Notify(ParameterChangedEventArgs args);

    class Publisher
    {
        public event Notify ArgumentChanged;

        public void CheckPassword(string password)
        {
            if (password.Equals("Lorem ipsum", StringComparison.Ordinal))
            {
                OnPasswordMatch(password);
            }
            if (password.Equals("x", StringComparison.Ordinal)) {
                Environment.Exit(0);
            }
        }

        protected void OnPasswordMatch(string password)
        {
            ParameterChangedEventArgs eventArgument = new(1, password);
            ArgumentChanged.Invoke(eventArgument);
        }
    }
}