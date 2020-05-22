using System;
namespace core.Models
{
    public class CatResponse
    {
        public bool Used { get; set; }

        public string Source { get; set; }

        public string Type { get; set; }

        public bool Deleted { get; set; }

        public string _Id { get; set; }

        public DateTime UpdatetAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string User { get; set; }

        public string Text { get; set; }

        public int __V { get; set; }

        public Status Status { get; set; }
    }

    public class Status
    {
        public bool Verified { get; set; }

        public int SentCount { get; set; }
    }
}
