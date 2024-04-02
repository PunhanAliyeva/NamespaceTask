﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NamespaceTask
{
    internal class Student:User
    {
        public int Grade { get; set; }

        public Student(string name, string surname, string username, string password,int grade) : base(name, surname, username, password)
        {
            Grade = grade;
        }
    }
}
