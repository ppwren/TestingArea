using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestingArea.Models;

namespace TestingArea.DAL
{
    public class DataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TopicsContext>
    {
        protected override void Seed(TopicsContext context)
        {
            var providers = new List<Provider>
            {
                new Provider{Title="Trinity College Dublin", Abbreviation="TCD" },
                new Provider{Title="Dublin City University", Abbreviation="DCU" },
                new Provider{Title="National University of Galway", Abbreviation="NUIG" },
                new Provider{Title="University of Limerick", Abbreviation="UL" }
            };

            providers.ForEach(p => context.Providers.Add(p));
            context.SaveChanges(1);

            var topics = new List<Topic>
            {
                new Topic{Title="Investigation into Auto-Logging", Description="Trying to create a test project to familiarize with SimpleMembership, Entity Framework, CodeFirst Principles and Auto logging", DateCreated=DateTime.Now, ProviderID = 1},
                new Topic{Title="Investigation into SimpleMenbership", Description="Trying to create a test project to familiarize with SimpleMembership only", DateCreated=DateTime.Now, ProviderID = 1},
                new Topic{Title="Xbox One, is it any good?", Description="Investigation to determine the effects xbox gaming has on men in their 30s", DateCreated=DateTime.Now, ProviderID = 2},
                new Topic{Title="Fantasy Novels, which are the best ones?", Description="Are there any good new fantasy novels?", DateCreated=DateTime.Now, ProviderID = 3},
                new Topic{Title="The effect of running on your knees.", Description="Does running have a long term effect on your knees", DateCreated=DateTime.Now, ProviderID = 4},
            };

            topics.ForEach(t => context.Topics.Add(t));
            context.SaveChanges(1);
        }
    }
}