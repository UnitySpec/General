namespace UnitySpec.General.Tracing
{
    public interface ITraceListener
    {
        void WriteTestOutput(string message);
        void WriteToolOutput(string message);
    }
}