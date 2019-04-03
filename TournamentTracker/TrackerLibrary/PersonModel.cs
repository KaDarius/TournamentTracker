using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// represents one person
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        /// <summary>
        /// cellphone is a string because the value will never change,
        /// a number is a number
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
