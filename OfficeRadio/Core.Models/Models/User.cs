﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        public int Id { get; set; }
        public string RegEmpNo { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
