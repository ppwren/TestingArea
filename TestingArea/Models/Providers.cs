using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingArea.Models
{
    public class Provider
    {
        public int ProviderID { get; set; }
        public string Title { get; set; }
        public string Abbreviation { get; set; }
        public virtual ICollection<Topic> ProviderTopics { get; set; }
    }
}