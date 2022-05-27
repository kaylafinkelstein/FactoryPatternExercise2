using System;

namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database do you want to use?: List, SQL, or Mongo?");
            
            var userInput = Console.ReadLine();

            IDataAccess  db = DataAccessFactory.GetDataAccessType(userInput);

             var Products = db.LoadData();
             db.SaveData();

            foreach(var product in Products)
            {
                Console.WriteLine($"{product.Name} Price{product.Price}");
            }
        }
    }
}
