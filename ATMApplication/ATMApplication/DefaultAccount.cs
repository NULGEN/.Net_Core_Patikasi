using System;
namespace ATMApplication
{
	public static class DefaultAccount
	{
        public static List<Person> persons = new List<Person>();//Bu listeye dışarıdan erişim gerektiği için statik tanımlanır

        static DefaultAccount()//persons listesine default değerler atamak için statik bir constuructor gereklidir
        {
            persons.Add(new Person("Ali", "Baba", 1234, "ciflik", 100));
           
            
        }
    }
}

