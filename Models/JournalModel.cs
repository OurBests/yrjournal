using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace yrjournal.Models
{
    public class JournalModel
    {
        public string Id { get; set; }  
        public string PairName { get; set; }
        public string Quantity { get; set; }
        public string Type { get; set; }
        public string PL { get; set; }
        public string SignalTimeFrame { get; set; }
        public string MainSignal { get; set; }
        public string ConfirmationSignal { get; set; }
        public string EntryTimeFrame { get; set; }
        public string EntryPhase { get; set; }
        public string RR { get; set; }
        public string MoneyPercent { get; set; }
        public string RiskFree { get; set; }
        public string TrendFollowing { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public string File { get; set; }
        
        [NotMapped]
        public string UserEmail { get; set; }

    }
}
