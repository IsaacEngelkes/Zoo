using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// Makes the dingo class.
    /// </summary>
    public class Dingo : Mammal
    {
        /// <summary>
        /// Sets the Dingo.
        /// </summary>
        /// <param name="gender"> Sets the gender.</param>
        /// <param name="name">Sets the name.</param>
        /// <param name="age">Sets the age.</param>
        /// <param name="weight">Sets the weight.</param>
        public Dingo(string gender, string name, int age, double weight)
                : base(gender, name, age, weight)
        {
        }

        /// <summary>
        ///  Sets the bark.
        /// </summary>
        /// <param name="food"> Sets the food.</param>
        public override void Eat(Food food)
        {
            base.Eat(food);

            this.Bark();
        }

        /// <summary>
        ///  Sets the bark.
        /// </summary>
        private void Bark()
        {
            this.HappinessLevel += 2;
        }
       }
}
