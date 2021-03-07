using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.TextFormatting;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent an employee.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Employee
    {
        /// <summary>
        /// The name of the employee.
        /// </summary>
        private string name;

        /// <summary>
        /// The employee's identification number.
        /// </summary>
        private int number;

        /// <summary>
        /// Sets the employee.
        /// </summary>
        /// <param name="name"> Sets the name. </param>
        /// <param name="number"> Sets the number. </param>>
        public Employee(string name, int number)
        {
            this.name = name;
            this.number = number;
        }

        /// <summary>
        ///  Delivers the animal.
        /// </summary>
        /// <param name="mother"> Sets the mother. </param>
        /// <returns> Returns baby. </returns>
        public Animal DeliverAnimal(Animal mother)
        {
            Animal baby = mother.Reproduce();

            baby.Name = "Baby";

            return baby;
        }

        /// <summary>
        /// Fills vending machine.
        /// </summary>
        /// <param name="machine"> Sets the machine. </param>
        public void FillVendingMachine(VendingMachine machine)
        {
            while (!machine.IsFull())
            {
                machine.AddFoodBag();
            }
        }
    }
}