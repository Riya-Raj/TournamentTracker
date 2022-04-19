using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The unique identifier for the person
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// represents the first name of the user
        /// </summary>
        public string Firstname { get; set; }
        /// <summary>
        /// represents the last name of the user.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Represents the email address of the user 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Represents the mobile number of the user
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get 
            {
                return $"{ Firstname } { Lastname }";
            }
        }


    }
}
