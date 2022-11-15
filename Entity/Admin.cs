using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Admin:IEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
