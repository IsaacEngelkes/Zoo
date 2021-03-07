using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    /// The class which is used to represent a zoo.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Zoo
    {
        /// <summary>
        /// The zoo's ticket booth.
        /// </summary>
        private Booth ticketBooth;

        /// <summary>
        /// The zoo's room for birthing animals.
        /// </summary>
        private BirthingRoom birthArea;

        /// <summary>
        /// The zoo's vending machine which allows guests to buy snacks for animals.
        /// </summary>
        private VendingMachine animalSnackMachine;

        /// <summary>
        /// The zoo's current visitor.
        /// </summary>
        private Guest visitor;

        /// <summary>
        /// Sets the lest of animals.
        /// </summary>
        private List<Animal> animals;

        /// <summary>
        /// The maximum number of guests the zoo can accommodate at a given time.
        /// </summary>
        private int capacity;

        /// <summary>
        /// The zoo's featured animal.
        /// </summary>

        /// <summary>
        /// The zoo's ladies' restroom.
        /// </summary>
        private Restroom ladiesRoom;

        /// <summary>
        /// The zoo's men's restroom.
        /// </summary>
        private Restroom mensRoom;

        /// <summary>
        /// The name of the zoo.
        /// </summary>
        private string name;

        /// <summary>
        /// Sets the zoo.
        /// </summary>
        /// <param name="name"> Sets the name. </param>
        /// <param name="capacity">Sets the capacity. </param>
        /// <param name="restroomCapacity">Sets the restroom capacity. </param>
        /// <param name="animalFoodPrice"> Sets the animals food price. </param>
        /// <param name="ticketBooth"> Sets the ticket booth. </param>
        /// <param name="doctor"> Sets the doctor. </param>
        /// <param name="visitor"> Sets the visitor. </param>
        public Zoo(string name, int capacity, int restroomCapacity, decimal animalFoodPrice, Booth ticketBooth, Employee doctor, Guest visitor)
        {
            this.animals = new List<Animal>();
            this.animalSnackMachine = new VendingMachine(animalFoodPrice);
            this.birthArea = new BirthingRoom(doctor);
            this.capacity = capacity;
            this.ladiesRoom = new Restroom(restroomCapacity, "Female");
            this.mensRoom = new Restroom(restroomCapacity, "Male");
            this.name = name;
            this.ticketBooth = ticketBooth;
            this.visitor = visitor;
        }

        /// <summary>
        /// Gets animal count.
        /// </summary>
        public int AnimalCount
        {
            get
            {
                return this.animals.Count;
            }
        }

        /// <summary>
        /// Gets the average animals weight.
        /// </summary>
        public double AverageAnimalWeight
        {
            get
            {
                return this.TotalAnimalWeight / this.animals.Count;
            }
        }

        /// <summary>
        /// Gets the birth area.
        /// </summary>
        public BirthingRoom BirthArea
        {
            get
            {
                return this.birthArea;
            }
        }

        /// <summary>
        /// Gets the total animal weight.
        /// </summary>
        public double TotalAnimalWeight
        {
            get
            {
                double totalWeight = 0;

                foreach (Animal a in this.animals)
                {
                    totalWeight += a.Weight;
                }

                return totalWeight;
            }
        }

        /// <summary>
        /// Gets the animal snack machine.
        /// </summary>
        public VendingMachine AnimalSnackMachine
        {
            get
            {
                return this.animalSnackMachine;
            }
        }

        /// <summary>
        /// Gets the visitor.
        /// </summary>
        public Guest Visitor
        {
            get
            {
                return this.visitor;
            }
        }

        /// <summary>
        /// Gets the get ticket booth.
        /// </summary>
        public Booth TicketBooth
        {
            get
            {
                return this.ticketBooth;
            }
        }

        /// <summary>
        /// Sets the add animal.
        /// </summary>
        /// <param name="animal"> Sets the animal. </param>
        public void AddAnimal(Animal animal)
        {
            if (animal != null)
            {
                this.animals.Add(animal);
            }
        }

        /// <summary>
        /// Sets the birth animal.
        /// </summary>
        /// <param name="mother"> Sets the mother. </param>
        public void BirthAnimal(Animal mother)
        {
            if (mother.IsPregnant)
            {
                Animal baby = this.BirthArea.BirthAnimal(mother);

                if (baby != null)
                {
                    this.animals.Add(baby);
                }
            }
        }

        /// <summary>
        /// Finds the correct animal.
        /// </summary>
        /// <param name="type"> Sets the type.</param>
        /// <returns> Returns the correct animal. </returns>
        public Animal FindAnimal(Type type)
        {
            Animal animal = null;

            foreach (Animal a in this.animals)
            {
                if (a.GetType() == type)
                {
                    animal = a;

                    break;
                }
            }

            return animal;
        }

        /// <summary>
        /// Finds the pregnant animal.
        /// </summary>
        /// <param name="type"> Sets the type. </param>
        /// <returns> Returns the animal. </returns>
        public Animal FindPregnantAnimal(Type type)
        {
            Animal animal = null;

            foreach (Animal a in this.animals)
            {
                if (a.GetType() == type && a.IsPregnant)
                {
                    animal = a;

                    break;
                }
            }

            return animal;
        }

        /// <summary>
        /// Wakes all animals.
        /// </summary>
        public void WakeAllAnimals()
        {
            foreach (Animal a in this.animals)
            {
                a.Move();
            }
        }
}
}