using System;

namespace constructers// bir kılası new leğimiz zamna çalışna bloktur
{
    class Program
    {
        static void Main(string[] args)
        {
          
           

            customer customer2 = new customer {Id=1,name="hüm",city="kayseri" };
            Console.WriteLine(customer2.Id+customer2.name+customer2.city);


            customer customer1 = new customer(2, "sümeyye", "izmir"); // altdaki satırla aynı iş 
            // 10. satırın çalışması için constructer a parametre atamalıyım !!!
            Console.WriteLine(customer1.Id + customer1.name + customer1.city);




        }
    }
    class customer
    {
        public customer()
        {
            //custemer 2 için bu çalışır default ss
        }
        public customer(int Id,string name,string city)
        {
            //defoult constructer yazılsadayazılmasada çalışır 
            Id = Id;
            name = name;
            city = city;  //cw de custemer1 e ait name city ıd  degerlerine ulaşmak için eşleşme yapılmalı


        }
        public int Id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

    }

}
