using FriendOrganizer.Model;
using System.Collections.Generic;


namespace FriendOrganizer.UI.Data
{
    public class FriendDataService : IFriendDataService
    {
        public IEnumerable<Friend> GetAll()
        {
            //TODO: Load data from real db
            yield return new Friend { FirstName = "Ihar1", LastName = "Hrunt1" };
            yield return new Friend { FirstName = "Ihar2", LastName = "Hrunt2" };
            yield return new Friend { FirstName = "Ihar3", LastName = "Hrunt3" };
            yield return new Friend { FirstName = "Ihar4", LastName = "Hrunt4" };
        }
    }
}
