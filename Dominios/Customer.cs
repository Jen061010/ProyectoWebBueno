﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios
{
    public class Customer:ICustomer
    {
        public string Nombre { get; set; }
        public string Phone { get; set; }
        public int Id { get; set; }
    }
}
