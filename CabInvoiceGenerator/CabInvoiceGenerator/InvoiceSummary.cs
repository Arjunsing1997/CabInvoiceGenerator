using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceSummary
    {
        //variables
        private double numberOfRides;
        public double totalFare;
        private double averageFare;

        /// <summary>
        /// Initializes a new instance of the <see cref="InVoiceSummary"/> class.
        /// </summary>
        /// <param name="numberofRides">The numberof rides.</param>
        /// <param name="totalFare">The total fare.</param>
        public InvoiceSummary( double totalFare, double numberOfRides)
        {
            this.numberOfRides = numberOfRides;
            this.totalFare = totalFare;
            //formula for average fare
            this.averageFare = this.totalFare / numberOfRides;
        }

        public InvoiceSummary(double totalFare, int length, double averageFare)
        {
            this.totalFare = totalFare;
            this.numberOfRides = length;
            this.averageFare = averageFare;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        // Over riding the Equals method so as to match the value of the object references
        // Default Equals method comapre the reference of the objects and not the values
        public override bool Equals(object obj)
        {
            //checks object is not null
            if (obj == null) return false;
            //checks if object is equal to invoice summary or not
            if (!(obj is InvoiceSummary)) return false;
            //converting object into invoice summary type
            InvoiceSummary inputedObject = (InvoiceSummary)obj;
            //returns value after comparing with both objects
            return this.numberOfRides == inputedObject.numberOfRides && this.totalFare == inputedObject.totalFare && this.averageFare == inputedObject.averageFare;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        // Overriding equals method require overriding the GetHashCode method also
        public override int GetHashCode()
        {
            return this.numberOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.averageFare.GetHashCode();
        }
    }
}
