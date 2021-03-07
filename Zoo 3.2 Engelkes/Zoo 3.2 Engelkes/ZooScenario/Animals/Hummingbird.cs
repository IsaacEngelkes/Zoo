using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Sets the Humming bird class.
    /// </summary>
    public class Hummingbird : Bird
    {
        /// <summary>
        /// Makes the Humming bird.
        /// </summary>
        /// <param name="gender">Sets the gender.</param>
        /// <param name="name">Sets the name.</param>
        /// <param name="age">Sets the age.</param>
        /// <param name="weight">Sets the weight.</param>
        public Hummingbird(string gender, string name, int age, double weight)
            : base(gender, name, age, weight)
        {
        }
    }
}
