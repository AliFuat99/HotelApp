using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Customer:IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string IdCard { get; set; }
    }
}
