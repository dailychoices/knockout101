﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace knockout101.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Friend> Friends { get; set; }
    }

    public class Friend
    {
        public string Name { get; set; }
        public bool IsOnTwitter { get; set; }
        public string TwitterName { get; set; }
    }
}