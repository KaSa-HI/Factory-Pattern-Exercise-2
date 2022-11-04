using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine($"I am reading data from SQLDataAccess class this is, i.e: list, SQL database, mongo database");
            return new List<Product>();
        }
        public void SaveData()
        {
            Console.WriteLine($"I am saving data to a SQLDataAccess database");
        }
    }
}
