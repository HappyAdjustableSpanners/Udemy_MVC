using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidli.ViewModels
{
    public class CustomerDetailsViewModel
    {
        public string Name { get; set; }
        public string MembershipType { get; set; }
        public DateTime? Birthdate { get; set; }
    }
}