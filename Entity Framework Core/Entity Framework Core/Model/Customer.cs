﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    public class Customer
    {
        public int CustomerId {  get; set; }
        public String? CustomerName { get; set; }
        public string? Phone {  get; set; }
        public string? Address {  get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated {  get; set; }

        public void Display()
        {
            Console.WriteLine("id:{0}, name:{1}, phone:{2}, address:{3}",
                CustomerId,CustomerName,Phone,Address);
        }
    }
}
