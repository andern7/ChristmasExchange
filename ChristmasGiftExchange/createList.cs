using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasGiftExchange
{
   public class createList
    {
        private List<Person> Family;

        public createList()
        {
            Family = new List<Person>();
        }

        public void addPerson(Person person){
           Family.Add(person);
        }

        public void addPerson(string firstName, string lastName)
        {            
            Family.Add(new Person(firstName, lastName));
        }

        public void removePerson(int index)
        {
            Family.RemoveAt(index);
        }

        public void removePerson(Person person){
            Family.Remove(person);
        }

        public string currentList(){
            string result = "";
            for (int i = 0; i < Family.Count; i++)
			{
			 result += Family[i].getFirstName() + " " + Family[i].getLastName() + " \r\n";
			}

            return result;
        }
        public string finalList()
        {
            try
            {
                ListChecker lc = new ListChecker(Family);
                return lc.getList();
            }
            catch (Exception )
            {
                return "Unable to create list. Please try again.";
            }
        }
    }
}
  

