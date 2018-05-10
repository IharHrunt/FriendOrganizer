namespace FriendOrganizer.DataAccess.Migrations
{
    using FriendOrganizer.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendOrganizer.DataAccess.FriendOrganizerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendOrganizer.DataAccess.FriendOrganizerDbContext context)
        {
            context.Friends.AddOrUpdate(fn => fn.FirstName,
                new Friend { FirstName = "Ihar1", LastName = "Hrunt1" },
                new Friend { FirstName = "Ihar2", LastName = "Hrunt2" },
                new Friend { FirstName = "Ihar3", LastName = "Hrunt3" },
                new Friend { FirstName = "Ihar4", LastName = "Hrunt4" }
            );

        }
    }
}
