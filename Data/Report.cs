using System;
using System.Collections.Generic;

#nullable disable

namespace ReportScData.Data
{
    public partial class Report
    {
        public int Id { get; set; }
        public int SeqNo { get; set; }
        public int Imo { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public string ReportType { get; set; }
        public string Spec { get; set; }
        public string Bridge { get; set; }
        public string EngineRoom { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public DateTime? ReceivedOnShoreAt { get; set; }
        public DateTime? TransferredToDatalakeAt { get; set; }
        public string Warnings { get; set; }
    }
}
