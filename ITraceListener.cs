﻿namespace UnityFlow.SpecFlow
{
    public interface ITraceListener
    {
        void WriteTestOutput(string message);
        void WriteToolOutput(string message);
    }
}