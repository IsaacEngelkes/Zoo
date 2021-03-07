using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a restroom.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Restroom
    {
        /// <summary>
        /// The maximum number of people allowed in the restroom at a given time.
        /// </summary>
        private int capacity;

        /// <summary>
        /// The gender of the restroom.
        /// </summary>
        private string gender;

        /// <summary>
        /// Sets the restroom.
        /// </summary>
        /// <param name="capacity"> Sets the capacity.</param>
        /// <param name="gender"> Sets the gender.</param>
        public Restroom(int capacity, string gender)
        {
            this.capacity = capacity;
            this.gender = gender;
        }
    }
}