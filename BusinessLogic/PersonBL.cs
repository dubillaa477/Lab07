using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PersonBL
    {
        List<Person> people = new List<Person>();
        public void Create(Person person)
        {
            if (string.IsNullOrEmpty(person.Name)) {
                throw new ArgumentException("Nombre vacio");
            }
            
            people.Add(person);

        }
        /// <summary>
        /// Finds the ones with
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        //When pero como cuando
        
        public Person GetbyId(int id)
        {
            foreach (var item in people) {
                if (item.Id == id) return item;
            }

            return null;
        }
    }
}
