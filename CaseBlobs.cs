using System;

namespace CoronavirusModels
{
    public class CaseBlobs
    {

        public int casesBlobId { get; set; }
        public DateTime DateScraped { get; set; }
        public string TotalCasesBlob { get; set; }
        public string TotalDeathsBlob { get; set; }
        public string TotalRecoveriesBlob { get; set; }
        public bool? Processed { get; set; }

    }
}