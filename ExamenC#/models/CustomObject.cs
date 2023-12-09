using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.models
{
    public class CustomObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomObject(int id, string Name) {
            Id = id;
            Name = Name;
        }
        public CustomObject(string Name)
        {
            Id = 0;
            Name = Name;
        }
        public CustomObject() { }
        public bool Equals(CustomObject x)
        {
            return x.Id == Id;
        }
        public int GetHashCode(CustomObject obj)
        {
            return (obj.Id).GetHashCode();
        }
    }
}
