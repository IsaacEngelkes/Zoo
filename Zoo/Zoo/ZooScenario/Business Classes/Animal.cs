using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an animal.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Animal
    {
        /// <summary>
        /// A reference to the (unborn) baby animal.
        /// Always null for male animals. Null for mother animals that are not pregnant.
        /// </summary>
        private readonly double afterbirthPercentage = 0.1;

        private readonly double babyWeightPercentage = 0.1;

        private readonly double eatBabyWeightGainPercentage = 0.1;

        private readonly double milkWeightPercentage = 0.005;

        private readonly double moveWeightLossPercentage = 0.03;

        private readonly double portionSizePercentage = 0.02;

        /// <summary>
        /// A value indicating whether or not the animal is pregnant.
        /// Always stores false for male animals. False for mother animals that are not pregnant.
        /// </summary>

        /// <summary>
        /// The name of the animal.
        /// </summary>
        private string name;

        /// <summary>
        /// The weight of the animal (in pounds).
        /// </summary>
        private double weight;

        /// <summary>
        /// The age of the animal.
        /// </summary>
        private int age;

        /// <summary>
        /// The gender the animal.
        /// </summary>
        private string gender;

        /// <summary>
        /// The happiness level the animal.
        /// </summary>
        private int happinessLevel;

        /// <summary>
        /// Sets the baby.
        /// </summary>
        private Animal baby;

        /// <summary>
        /// Sets the animal.
        /// </summary>
        /// <param name="gender"> Sets the gender. </param>
        /// <param name="name"> Sets the name. </param>
        /// <param name="age"> Sets the age. </param>
        /// <param name="weight"> Sets the weight. </param>
        public Animal(string gender, string name, int age, double weight)
        {
            this.age = age;
            this.gender = gender;
            this.name = name;
            this.weight = weight;
        }

        /// <summary>
        /// Gets a value indicating whether is pregnant.
        /// </summary>
        public bool IsPregnant
        {
            get
            {
                return this.baby != null;
            }
        }

        /// <summary>
        /// Gets the portion size.
        /// </summary>
        public double PortionSize
        {
            get
            {
                return this.weight * this.portionSizePercentage;
            }
        }

        /// <summary>
        /// Gets the weight.
        /// </summary>
        public double Weight
        {
            get
            {
                return this.weight;
            }
        }

        /// <summary>
        ///  Gets the eat weight percentage.
        /// </summary>
        public virtual double EatWeightGainPercentage
        {
            get
            {
                return 0.0;
            }
        }

        /// <summary>
        /// Gets or sets the happiness level.
        /// </summary>
        public int HappinessLevel
        {
            get
            {
                return this.happinessLevel;
            }

            set
            {
                this.happinessLevel = value;
            }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Makes the animal pregnant.
        /// </summary>
        public void MakePregnant()
        {
            if (this.gender == "Female" && !this.IsPregnant)
            {
                this.baby = new Animal("Male", string.Empty, 0, this.weight * this.babyWeightPercentage);
            }

            switch (this.GetType().Name)
            {
                case "Dingo":
                    this.baby = new Dingo("Male", string.Empty, 0, this.Weight * this.babyWeightPercentage);
                    break;
                case "Platypus":
                    this.baby = new Platypus("Male", string.Empty, 0, this.Weight * this.babyWeightPercentage);
                    break;
                case "Hummingbird":
                    this.baby = new Hummingbird("Male", string.Empty, 0, this.Weight * this.babyWeightPercentage);
                    break;
            }
        }

            /// <summary>
            /// Enables the animals to put on food weight.
            /// </summary>
            /// <param name="food"> The object that initiated the food weight.</param>
        public virtual void Eat(Food food)
        {
        double weightGain = food.Weight * this.EatWeightGainPercentage;

        this.weight += weightGain;

        if (this.baby != null)
        {
        double babyWeightGain = food.Weight * this.eatBabyWeightGainPercentage;

        this.baby.weight += babyWeightGain;
        }
        }

        /// <summary>
        /// Moves the weight.
        /// </summary>
        public void Move()
        {
            double weightLossAmount = this.weight * this.moveWeightLossPercentage;

            this.weight -= weightLossAmount;
        }

        /// <summary>
        /// Sets the reproduce property.
        /// </summary>
        /// <returns> Returns the baby. </returns>
        public Animal Reproduce()
        {
            Animal baby = this.baby;

            this.baby = null;

            this.weight -= baby.weight;

            this.weight -= baby.weight * this.afterbirthPercentage;

            this.Move();

            if (this.GetType().Name != "Platypus")
            {
                this.FeedNewborn(this.baby);
            }

            return baby;
        }

        /// <summary>
        /// Feeds the newborn.
        /// </summary>
        /// <param name="newborn"> Sets the new born. </param>
        private void FeedNewborn(Animal newborn)
        {
            this.weight -= newborn.Nurse(this);
        }

        /// <summary>
        /// Assigns the nurse.
        /// </summary>
        /// <param name="mother"> Sets the mother. </param>
        /// <returns> Returns the milk weight. </returns>
        private double Nurse(Animal mother)
        {
            double milkWeight = mother.weight * this.milkWeightPercentage;

            Food milk = new Food(milkWeight);

            this.Eat(milk);

            return milkWeight;
        }
    }
}