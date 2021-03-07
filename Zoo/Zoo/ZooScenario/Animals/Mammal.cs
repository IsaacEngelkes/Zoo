using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Sets the Mammal.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Mammal : Animal
        {
        /// <summary>
        /// Sets the weight percentage.
        /// </summary>
        private readonly double eatWeightGainPercentage = 0.8;

        /// <summary>
        /// Sets the mammal.
        /// </summary>
        /// <param name="gender">Sets the gender.</param>
        /// <param name="name">Sets the name. </param>
        /// <param name="age">Sets the age. </param>
        /// <param name="weight">Sets the weight. </param>
        public Mammal(string gender, string name, int age, double weight)
                            : base(gender, name, age, weight)
        {
        }

        /// <summary>
        /// Gets the weight percentage.
        /// </summary>
        public override double EatWeightGainPercentage
        {
            get
            {
                return this.eatWeightGainPercentage;
            }
        }
    }
}
