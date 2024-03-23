using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentAMovie.Models;

namespace RentAMovie.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public IEnumerable<MembershipType> MembershipTypes { get; set; }

        //set title of the form as new customer or edit customer
        public string Title
        {
            get { return Customer.Id == 0 ? "New Customer" : "Edit Customer"; }
        }
    }
}