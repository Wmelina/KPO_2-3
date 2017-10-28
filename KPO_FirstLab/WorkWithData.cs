using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;

namespace KPO_FirstLab
{
    class WorkWithData
    {
        public void Serialization(QueueRealisation<Person> peeerson) 
        {
            int countCheck = 0;
            Person[] people = new Person[peeerson.count];
            foreach (Person item in peeerson) 
            {
                people[countCheck] = item;
                countCheck++;
            }
           
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[])); 
            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, people);
            }
        }
        public void Deserialization(string jsonstr) 
        {
            using (FileStream fs = new FileStream(jsonstr, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Person[])); 
                Person[] newpeople = (Person[])jsonFormatter.ReadObject(fs);
            }
            Console.ReadLine();
        }
    }
    
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }

        public Person(string name, int year)
        {
            Name = name;
            Age = year;
        }
    }


}
