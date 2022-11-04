namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Database would you like to Select? ");
            string userInput = Console.ReadLine();
            IDataAccess uI = DataAccessFactory.GetDataAccessType(userInput);
            uI.LoadData();
            uI.SaveData();
        }
    }
}
