﻿using System;
namespace XApp6.Models
{
    public class User
    {
		public int id { get; set; }
		public string name { get; set; }
		public int age { get; set; }
		public List<Wish> wishes { get; set; }
    }
}
