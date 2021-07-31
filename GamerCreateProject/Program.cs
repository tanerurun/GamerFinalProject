using System;

namespace GamerCreateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 2,
                Name = "Taner",
                LastName= "Ürün",
                Email= "taner.urun@outlook.com"
            });
           
            Console.WriteLine("Hello World!");
        }
    }
}
/*
 


 5 gamer kontrol edilecek metot yazılacak.


  
 
 
 
 
 
 */