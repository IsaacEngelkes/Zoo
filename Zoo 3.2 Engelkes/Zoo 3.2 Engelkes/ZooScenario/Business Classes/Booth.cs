using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a booth.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Booth
    {
        /// <summary>
        /// The employee currently assigned to be the attendant of the booth.
        /// </summary>
        private Employee attendant;

        /// <summary>
        /// The price of a ticket.
        /// </summary>
        private decimal ticketPrice;

        /// <summary>
        /// Sets the booth.
        /// </summary>
        /// <param name="attendant"> Sets the attendant. </param>
        /// <param name="ticketPrice"> Sets the ticket price. </param>
        public Booth(Employee attendant, decimal ticketPrice)
        {
            this.attendant = attendant;
            this.ticketPrice = ticketPrice;
        }

        /// <summary>
        /// Gets the attendant.
        /// </summary>
        public Employee Attendant
        {
            get
            {
                return this.attendant;
            }
        }
    }
}