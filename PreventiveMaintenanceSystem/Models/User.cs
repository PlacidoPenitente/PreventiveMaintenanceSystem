using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace PreventiveMaintenanceSystem.Models
{
    public class User : IModel
    {
        public int Id { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Gender")]
        public Gender Gender { get; set; }

        [DisplayName("Address")]
        public string Address { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Contact No.")]
        public string ContactNo { get; set; }

        [DisplayName("User Type")]
        public AccountType AccountType { get; set; }

        [DisplayName("Username")]
        public string Username { get; set; }

        [DisplayName("Password")]
        public string Password { get; set; }

        [DisplayName("Security Question No. 1")]
        public string SecurityQuestion1 { get; set; }

        [DisplayName("Security Question No. 2")]
        public string SecurityQuestion2 { get; set; }

        [DisplayName("Answer")]
        public string SecurityQuestion1Answer { get; set; }

        [DisplayName("Answer")]
        public string SecurityQuestion2Answer { get; set; }

        [DisplayName("Date Added")]
        public DateTime DateAdded { get; set; }

        [DisplayName("Date Modified")]
        public DateTime DateModified { get; set; }
    }
}