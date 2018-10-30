using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Person
    {
        public DateTime BirthDay { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }


        public int Age(DateTime BirthDay) {
            DateTime nacimiento  = new DateTime(BirthDay.Year, BirthDay.Month, BirthDay.Day); //Fecha de nacimiento
            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
            return edad;   
        }
    }
}
