using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasGiftExchange
{
    public class ListChecker
    {
        private List<Person> FamilyOrdered;
        private List<Person> FamilyRandom;
        Random r = new Random();
        public string message = "Cannot match names. Add more names and try again.";
        private int TimesListTried = 0;

       
        public ListChecker(List<Person> Family)
        {
                        
            FamilyOrdered = new List<Person>(Family);
            FamilyRandom = new List<Person>(Family);

            this.FamilyRandom = shuffle(this.FamilyRandom);

        }

       

        private Boolean isValidList(List<Person> Family)
        {
            int length = Family.Count();
            Family.Sort();

            int lastIndex = 0;
            int firstIndex = 0;
            String currentName = "";

            for (int i = 0; i < length; i++)
            {
                if (!Family[i].getLastName().Equals(currentName))
                {
                    currentName = Family[i].getLastName();
                    firstIndex = i;
                }

                lastIndex = i;

                if ((lastIndex - firstIndex) >= (length / 2))
                {
                    return false;
                }
            }
            return true;

        }
        public List<Person> shuffle(List<Person> Family)
        {
            Random rng = new Random();
            int n = Family.Count();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Person value = Family[k];
                Family[k] = Family[n];
                Family[n] = value;
            }
            return Family;

        }

        public string getList()
        {
                TimesListTried++;

                int length = FamilyOrdered.Count();
                string result = "";

                for (int i = 0; i < length; i++)
                    {
                    if (FamilyOrdered[i].getLastName().Equals(FamilyRandom[i].getLastName()))
                    {
                        this.FamilyRandom = shuffle(this.FamilyRandom);
                        return getList();
                    }

                    result += FamilyOrdered[i].getFirstName() + " " +
                            FamilyOrdered[i].getLastName() + " gives gift to " +
                            FamilyRandom[i].getFirstName() + " " +
                            FamilyRandom[i].getLastName() + '\r' + '\n';


                    }
                return result + '\r' + '\n' + " The list was sorted " + TimesListTried.ToString() + "Times";
            }
           

        }

    }

           
        
       
    
         
			
    



