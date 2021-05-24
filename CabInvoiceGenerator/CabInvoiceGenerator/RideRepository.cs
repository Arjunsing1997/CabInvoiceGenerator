using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> userRide = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="RideRepository"/> class.
        /// Creating a constructor
        /// </summary>
        public RideRepository()
        {
            this.userRide = new Dictionary<string, List<Ride>>();
        }

        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList = this.userRide.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    this.userRide.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_RIDES, "Invalid Rides");

            }
        }

        public  Ride[] GetRide(string userId)
        {
            try
            {
                return this.userRide[userId].ToArray();
            }
            catch
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid User Id");
            }
        }
    }
}
