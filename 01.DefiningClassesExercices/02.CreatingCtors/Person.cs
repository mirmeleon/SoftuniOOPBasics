﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CreatingCtors
{
  public  class Person
    {
        public string name;
        public int age;

        public Person()
        {
            this.name = "No name";
            this.age = 1;
        }

        public Person(int age) : this () //vika praznia
        {
            this.age = age;
        }

        public Person(int age, string name) : this()
        {
            this.age = age;
            this.name = name;
        }
    }
}