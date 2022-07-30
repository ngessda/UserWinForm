﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User
{
    public class ClassUser : ICloneable
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public override string ToString()
        {
            return $"[{Id}] - {Username}";
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
