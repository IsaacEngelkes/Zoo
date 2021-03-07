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
    public class BirthingRoom
    {
        /// <summary>
        /// The current temperature of the birthing room.
        /// </summary>
        private readonly double initialTemperature;

        private readonly double temperatureIncrease;

        private readonly double minTemperature = 35.0;

        private readonly double maxTemperature = 95.0;

        /// <summary>
        /// The doctor for the birthing room.
        /// </summary>
        private Employee doctor;

        private double temperature;

        /// <summary>
        /// Sets the BirthingRoom.
        /// </summary>
        /// <param name="doctor"> Sets the doctor. </param>
        public BirthingRoom(Employee doctor)
        {
            this.initialTemperature = 77.0;
            this.temperatureIncrease = 0.5;

            this.temperature = this.initialTemperature;
            this.doctor = doctor;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        public Employee Doctor
        {
            get
            {
                return this.doctor;
            }
        }

        /// <summary>
        /// Gets or sets the temperature.
        /// </summary>
        public double Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                if (value >= this.minTemperature && value <= this.maxTemperature)
                {
                    this.temperature = value;
                }
            }
        }

        /// <summary>
        /// Sets the mother.
        /// </summary>
        /// <param name="mother"> Defines the mother.</param>
        /// <returns> Returns baby. </returns>
        public Animal BirthAnimal(Animal mother)
        {
            Animal baby = null;

            if (mother != null && mother.IsPregnant)
            {
                baby = this.doctor.DeliverAnimal(mother);

                this.Temperature += this.temperatureIncrease;
            }

            return baby;
        }
    }
}
