using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Makes the bird class.
    /// </summary>
   public class Bird : Animal
    {
        /// <summary>
        /// Sets the eat weight gain.
        /// </summary>
        private readonly double eatWeightGainPercentage = 0.64;

        /// <summary>
        /// Sets the bird.
        /// </summary>
        /// <param name="gender">Sets the gender.</param>
        /// <param name="name">Sets the name.</param>
        /// <param name="age">Sets the age.</param>
        /// <param name="weight">Sets the weight.</param>
        public Bird(string gender, string name, int age, double weight)
                            : base(gender, name, age, weight)
        {
        }

        /// <summary>
        /// Gets the eat weight gain percentage.
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
