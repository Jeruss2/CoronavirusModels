using System;

namespace CoronavirusModels
{
    public class VirusErrorLog
    {
        public string ExceptionMessage { get; set; }

        public DateTime? DateAdded { get; set; }

        public string StackTrace { get; set; }

        public string ApplicationName { get; set; }
    }
}