using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSTO.Model
{
    internal class Master
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Level { get; set; }
        public string Services { get; set; }

        public Master() { }

        public Master(int id, string firstName, string secondName, string thirdName, string level, string services)
        {
            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            Level = level;
            Services = services;
        }
    }
}
