﻿using System;
using System.Collections.Generic;

namespace GuitarBookingSystem.Models
{
   public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ClassID { get; set; }
        public Class Class { get; set; }
    }
}
