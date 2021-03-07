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
    public class Platypus : Mammal
    {
        /// <summary>
        /// Sets the Platypus.
        /// </summary>
        /// <param name="gender">Sets the Gender.</param>
        /// <param name="name">Sets the name.</param>
        /// <param name="age">Sets the age.</param>
        /// <param name="weight">Sets the weight.</param>
        public Platypus(string gender, string name, int age, double weight)
            : base(gender, name, age, weight)
        {
        }

        /// <summary>
        /// Sets the eat method.
        /// </summary>
        /// <param name="food">Sets the food.</param>
        public override void Eat(Food food)
        {
            this.StashInPouch(food);
            base.Eat(food);
        }

        /// <summary>
        /// How the animal eats.
        /// </summary>
        /// <param name="food">The object that initiated the food weight.</param>
        private void StashInPouch(Food food)
        {
            this.HappinessLevel += 1;
        }
    }
}
