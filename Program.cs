namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic_Task basic_Task = new Basic_Task();

            //Happy Ladybugs
            Console.WriteLine(basic_Task.Happy_ladybugs("RBY_YBR"));

            //Cavity Map
            List<string> grid = new List<string>();
            grid = ["1112", "1912", "1892", "1234"];
            grid = basic_Task.Cavity_Map(grid);
            foreach (string item in grid)
            {
                Console.WriteLine(item);
            }

            //Modified Kaprekar Numbers
            Console.WriteLine(basic_Task.kaprekarNumbers(1, 100));
        }
    }
}
