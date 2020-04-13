using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Mongo_01
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("myFristDb");
            var collection = db.GetCollection<Student>("students");
            Student student = new Student("Nhoppasit", "Srisurat");
            collection.InsertOne(student);
        }
    }
}
