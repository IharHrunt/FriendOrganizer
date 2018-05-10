using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public FriendDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;
        }

        public async Task<List<Friend>> GetAllAsync()
        {
            //TODO: Load data from real db
            //yield return new Friend { FirstName = "Ihar1", LastName = "Hrunt1" };
            //yield return new Friend { FirstName = "Ihar2", LastName = "Hrunt2" };
            //yield return new Friend { FirstName = "Ihar3", LastName = "Hrunt3" };
            //yield return new Friend { FirstName = "Ihar4", LastName = "Hrunt4" };

            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().ToListAsync();
            }

        }
    }
}
