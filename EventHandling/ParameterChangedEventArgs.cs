namespace EventHandling
{
    public class ParameterChangedEventArgs : EventArgs
    {
        public int IntParameter { get; set; }
        public string StrParameter { get; set; }

        public ParameterChangedEventArgs(int intParameter, string strParameter)
        {
            IntParameter = intParameter;
            StrParameter = strParameter;
        }
    }
}
