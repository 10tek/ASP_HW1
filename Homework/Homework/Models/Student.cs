using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework.Models
{
    public class Student : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}