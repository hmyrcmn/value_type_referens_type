using System;

namespace value_type_referens_type
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type =int float decimal double enum 
            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;// ile sayı2 nın degerini sayi1 e atadım DEGER VALUE
            sayi2 = 100;
            Console.WriteLine("sayı2: " + sayi2 + "sayı1: " + sayi1);
            //sayı2=100 ,sayı1=20 yanı sayı2 nın önceki degeri nı yazar say

            //referend type  array class interface 
            int[] sayilar1 = new int[] { 1, 2, 3 }; //degrleri yokolur 
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2; // sayılar 2 nın bellek adresini sayı 1 atarım 
            sayilar2[0] = 50;
            Console.WriteLine("sayılar1[0]:  "+ sayilar1[0]+"           sayılar2[0]: "+sayilar2[0]);
            person person1 = new person();
            person1.name = "hümeyra";
            person1.surname = "çimen";
            person1.Id = 305;


            person person2 = new person();
            person2.name = "meyye";
            person2.surname = "çimennn";
            person2.Id =256;

            custemer custemer1 = new custemer();
            custemer1.cardnumber =" 123456789";
            custemer custemer2 = new custemer();

            employee employee = new employee();

            person person3 = custemer2 ;
            person3.name = "hello";
            Console.WriteLine(custemer2.name+"----------");
           
            Console.WriteLine(custemer1.Id+custemer1.surname+custemer1.cardnumber);


            // note :
            Console.WriteLine("***************************");


            custemer2.cardnumber = "98765432";
            Console.WriteLine (((custemer)person3).cardnumber);

            manager manager = new manager();
            manager.Add(person3);


        }
    }//base class person 
    class person 
    {
        public string name { get; set; }
        public int Id { get; set; }
        public string surname { get; set; }


    }
    class custemer:person
    {
        public string cardnumber { get; set; }
    }
    class employee:person
    {
        public int employee_ıd { get; set; }

    }
    class manager
    {
        public void Add(person person)
        {
            Console.WriteLine(person.name);

        }
          
    }

   

}
