using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class that defines the Vending Machine.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]

    public class VendingMachine
{
        private readonly double bagSize;

        private readonly double foodCapacity;

        /// <summary>
        /// The price of food (per pound).
        /// </summary>
        private decimal foodPricePerPound;

        /// <summary>
        /// The amount of food currently in stock (in pounds).
        /// </summary>
        private double foodStock;

        /// <summary>
        /// The amount of money currently in the vending machine.
        /// </summary>
        private decimal moneyBalance;

        /// <summary>
        /// Sets the vending machine.
        /// </summary>
        /// <param name="foodprice"> Sets the food price. </param>
        public VendingMachine(decimal foodprice)
        {
            this.bagSize = 65.0;
            this.foodCapacity = 250.0;
            this.foodPricePerPound = foodprice;

            while (!this.IsFull())
            {
                this.AddFoodBag();
            }
        }

        /// <summary>
        /// Adds Money.
        /// </summary>
        /// <param name="amount">The object that initiated the amount.</param>
        public void AddMoney(decimal amount)
        {
            this.moneyBalance += amount;
        }

        /// <summary>
        /// Sets is the animal full.
        /// </summary>
        /// <returns> Retursn the food stock. </returns>
        public bool IsFull()
        {
            if (this.foodStock >= this.foodCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Sells the food.
        /// </summary>
        /// <param name="payment">The object that initiated the payment.</param>
        /// <returns> Returns the food weight. </returns>
        public Food SellFood(decimal payment)
        {
            this.AddMoney(payment);

            double foodWeight = (double)(payment * this.foodPricePerPound);

            this.foodStock -= foodWeight;

            Food food = new Food(foodWeight);

            return food;
        }

        /// <summary>
        /// Sets the max food weight.
        /// </summary>
        /// <param name="maxFoodWeight"> Sets the food weight.</param>
        /// <returns> Returns the food cost. </returns>
        public decimal DetermineFoodCost(double maxFoodWeight)
        {
        decimal maxFoodCost = this.foodPricePerPound * (decimal)maxFoodWeight;

        // Round the food cost to the nearest hundredth.
        decimal foodCost = Math.Round(maxFoodCost, 2);

        return foodCost;
        }

        /// <summary>
        /// Adds food to the bag.
        /// </summary>
        public void AddFoodBag()
        {
            this.foodStock = Math.Min(this.foodStock + this.bagSize, this.foodCapacity);
        }
    }
}
