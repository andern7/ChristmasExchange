using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ChristmasGiftExchange
{
    public class Person 
    {
        private string firstName;
        protected string lastName;

        public Person(string firstName, string lastName){
            this.firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
            this.lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();
        }

        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
        }

        public string getLastName()
        {
            return lastName;
        }
        public void setLastName(string lastName)
        {
            this.lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();
        }

        
      
        
    }
}
