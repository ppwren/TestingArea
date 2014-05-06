using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingArea.Models
{
    public class Topic
    {
        public int TopicID { get; set; }
        public int ProviderID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }

    }
}