using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a birthing room.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Guest
    {
        /// <summary>
        /// The age of the guest.
        /// </summary>
        private int age;

        /// <summary>
        /// The name of the guest.
        /// </summary>
        private string name;

        /// <summary>
        /// The guest's purse.
        /// </summary>
        private Wallet wallet;

        /// <summary>
        /// Sets the guest.
        /// </summary>
        /// <param name="name"> Sets the name. </param>
        /// <param name="age"> Sets the age. </param>
        /// <param name="moneyBalance">Sets the money balance. </param>
        public Guest(string name, int age, decimal moneyBalance)
        {
            this.age = age;
            this.name = name;
            this.wallet = new Wallet();
            this.AddMoney(moneyBalance);
        }

        /// <summary>
        /// Gets the money balance.
        /// </summary>
        public decimal MoneyBalance
        {
            get
            {
                return this.wallet.MoneyBalance;
            }
        }

        /// <summary>
        /// Sets the add money.
        /// </summary>
        /// <param name="amount"> Sets the amount. </param>
        public void AddMoney(decimal amount)
        {
            this.wallet.AddMoney(amount);
        }

        /// <summary>
        /// Feeds the specified animal.
        /// </summary>
        /// <param name="animal">The animal to be fed.</param>
        /// <param name="animalSnackMachine">The animal snack machine from which to buy food.</param>
        public void FeedAnimal(Animal animal, VendingMachine animalSnackMachine)
        {
            double maxFoodWeight = animal.PortionSize;

            decimal foodCost = animalSnackMachine.DetermineFoodCost(maxFoodWeight);

            if (this.MoneyBalance >= foodCost)
            {
                decimal foodPayment = this.RemoveMoney(foodCost);

                Food food = animalSnackMachine.SellFood(foodPayment);

                animal.Eat(food);
            }
        }

        /// <summary>
        /// Removes the money.
        /// </summary>
        /// <param name="amount"> sets the amount.</param>
        /// <returns> Returns the removed amount. </returns>
        public decimal RemoveMoney(decimal amount)
        {
            decimal amountRemoved = this.wallet.RemoveMoney(amount);

            return amountRemoved;
}
}
}
