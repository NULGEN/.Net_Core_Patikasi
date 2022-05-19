using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJE_2__Console_ToDo_Uygulaması
{
    internal class PersonInfo
    {
        public static List<Person> person = new List<Person>();

        public  PersonInfo()
        {
             
            person.Add(new Person(1, "Ayşe Yılmaz"));
            person.Add(new Person(2, "Ali Korkmaz"));
            person.Add(new Person(3, "Mehmet Sert"));
            person.Add(new Person(4, "Zehra Koru"));
            person.Add(new Person(5, "Fatih Duru"));
            
        }
    }
}
