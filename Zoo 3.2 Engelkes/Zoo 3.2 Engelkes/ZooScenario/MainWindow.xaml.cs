using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ZooScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Minnesota's Como Zoo.
        /// </summary>
        private Zoo comoZoo;

        /// <summary>
        /// SanDiegoZoo Zoo.
        /// </summary>
        private Zoo sanDiegoZoo;

        /// <summary>
        /// The number of the animals in one of the zoos.
        /// </summary>
        private int zooAnimalCount;

        /// <summary>
        /// The average weight of the animals in one of the zoos.
        /// </summary>
        private double zooAverageAnimalWeight;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates the Como Zoo and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newComoZooButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Zoo class.
            Booth booth = new Booth(new Employee("Sam", 42), 15.00m);
            Employee doctor = new Employee("Flora", 98);
            Guest visitor = new Guest("Darla", 11, 5.25m);
            this.comoZoo = new Zoo("Como Zoo", 1000, 4, 0.75m, booth, doctor, visitor);

            Animal animal = new Dingo("Female", "Dolly", 4, 35.3);
            animal.MakePregnant();
            this.comoZoo.AddAnimal(animal);

            animal = new Dingo("Female", "Dixie", 3, 33.8);
            animal.MakePregnant();
            this.comoZoo.AddAnimal(animal);

            animal = new Platypus("Female", "Pammy", 2, 15.5);
            animal.MakePregnant();
            this.comoZoo.AddAnimal(animal);
            }

        /// <summary>
        /// Creates the San Diego Zoo and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newSanDiegoZooButton_Click(object sender, RoutedEventArgs e)
        {
            Booth booth = new Booth(new Employee("Betty", 84), 25.50m);
            Employee doctor = new Employee("Steve", 24);
            Guest visitor = new Guest("Dave", 13, 3.75m);

            this.sanDiegoZoo = new Zoo("San Diego Zoo", 3000, 12, 1.20m, booth, doctor, visitor);

            Animal animal = new Platypus("Female", "Patti", 5, 3.27);
            animal.MakePregnant();
            this.sanDiegoZoo.AddAnimal(animal);

            animal = new Hummingbird("Male", "Harold", 1, 0.5);
            this.sanDiegoZoo.AddAnimal(animal);
        }

        /// <summary>
        /// Creates the San Diego Zoo and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void darlaFeedDingoButton_Click(object sender, RoutedEventArgs e)
        {
            this.comoZoo.Visitor.FeedAnimal(this.comoZoo.FindAnimal(typeof(Dingo)), this.comoZoo.AnimalSnackMachine);
        }

        private void daveFeedPlatypusButton_Click(object sender, RoutedEventArgs e)
        {
            this.sanDiegoZoo.Visitor.FeedAnimal(this.sanDiegoZoo.FindAnimal(typeof(Platypus)), this.sanDiegoZoo.AnimalSnackMachine);
        }

        private void birthDingoButton_Click(object sender, RoutedEventArgs e)
        {
            this.comoZoo.BirthAnimal(this.comoZoo.FindPregnantAnimal(typeof(Dingo)));
        }

        private void birthPlatypusButton_Click(object sender, RoutedEventArgs e)
        {
            this.sanDiegoZoo.BirthAnimal(this.sanDiegoZoo.FindPregnantAnimal(typeof(Platypus)));
        }

        private void floraFillVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {
            this.sanDiegoZoo.TicketBooth.Attendant.FillVendingMachine(this.sanDiegoZoo.AnimalSnackMachine);
        }

        private void bettyFillVendingMachineButton_Click(object sender, RoutedEventArgs e)
        {
            this.comoZoo.TicketBooth.Attendant.FillVendingMachine(this.comoZoo.AnimalSnackMachine);
        }

        private void comoZooWakeAllAnimals_Click(object sender, RoutedEventArgs e)
        {
            this.comoZoo.WakeAllAnimals();
        }

        private void sanDiegoZooWakeAllAnimals_Click(object sender, RoutedEventArgs e)
        {
            this.sanDiegoZoo.WakeAllAnimals();
        }

        private void getComoZooAnimalCount_Click(object sender, RoutedEventArgs e)
        {
            this.zooAnimalCount = this.comoZoo.AnimalCount;
        }

        private void getComoZooAverageAnimalWeight_Click(object sender, RoutedEventArgs e)
        {
            this.zooAverageAnimalWeight = this.comoZoo.AverageAnimalWeight;
        }

        private void getSanDiegoZooAnimalCount_Click(object sender, RoutedEventArgs e)
        {
            this.zooAnimalCount = this.sanDiegoZoo.AnimalCount;
        }

        private void getSanDiegoZooAverageAnimalWeight_Click(object sender, RoutedEventArgs e)
        {
            this.zooAverageAnimalWeight = this.sanDiegoZoo.AverageAnimalWeight;
        }
    }
}