using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represents the Wallet.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Wallet
    {
        /// <summary>
        /// The amount of money currently contained within the wallet.
        /// </summary>
        private decimal moneyBalance;

        /// <summary>
        /// Gets the money balance.
        /// </summary>
        public decimal MoneyBalance
        {
            get
            {
                return this.moneyBalance;
            }
        }

        /// <summary>
        /// Sets add money.
        /// </summary>
        /// <param name="amount"> Sets the amount. </param>
        public void AddMoney(decimal amount)
        {
            if (amount > 0)
            {
             this.moneyBalance += amount;
            }
        }

        /// <summary>
        /// Removes a specified amount of money from the wallet.
        /// </summary>
        /// <param name="amount">The object that initiated the amount.</param>
        /// <returns> Returns the removed amount. </returns>
        public decimal RemoveMoney(decimal amount)
    {
            decimal amountRemoved;

            if (amount > 0.00m)
            {
                if (this.moneyBalance >= amount)
                {
                    amountRemoved = amount;
                }
                else
                {
                    amountRemoved = this.moneyBalance;
                }
            }
            else
            {
                amountRemoved = 0.00m;
            }

            this.moneyBalance -= amountRemoved;

            return amountRemoved;
}
    }
}
