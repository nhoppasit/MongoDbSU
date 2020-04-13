using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Mongo_01
{
    class Student
    {
        public ObjectId Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public Student(string first_Name, string last_Name)
        {
            First_Name = first_Name;
            Last_Name = last_Name;
        }
    }
}
