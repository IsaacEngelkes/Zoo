using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooScenario
{
    /// <summary>
    ///  Sets the food class.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public class Food
    {
    /// <summary>
    /// adds the weight.
    /// </summary>
    private double weight;

    /// <summary>
    /// Sets the food.
    /// </summary>
    /// <param name="weight"> Sets the weight. </param>
    public Food(double weight)
    {
          this.weight = weight;
    }

        /// <summary>
        /// Gets the foods weight.
        /// </summary>
    public double Weight
    {
         get
         {
            return this.weight;
         }
    }
    }
}
