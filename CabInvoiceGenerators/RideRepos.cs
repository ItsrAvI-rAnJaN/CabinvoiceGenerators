using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerators
{
    public class RideRepos
    {
        Dictionary<string, List<Rides>> userRides = null;

        public RideRepos()
        {
            userRides = new Dictionary<string, List<Rides>>();
        }

        public void AddRide(string userId, Rides[] rides)
        {
            bool rideList = userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Rides> list = new List<Rides>();
                    list.AddRange(rides);
                    userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are null");
            }
        }

        public Rides[] GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid user Id");
            }
        }
    }
}
