using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barbershop_Booking_App
{
    /// <summary>
    /// Represents a barber in the barbershop.
    /// </summary>
    public class Barber
    {
        /// <summary>
        /// Gets or sets the name of the barber.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the experience of the barber in years.
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Barber"/> class.
        /// </summary>
        /// <param name="name">The name of the barber.</param>
        /// <param name="experience">The experience of the barber in years.</param>
        public Barber(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return $"{Name}\t\t{Experience} years";
        }
    }
}
