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

            //ACM ICPC TEAM
            List<string> topic = new List<string>();
            topic = ["10101", "11100", "11010", "00101"];
            List<int> newList = basic_Task.acmTeam(topic);
            //foreach (var item in newList)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine(String.Join(" ", newList.ToArray()));

            //Fair Rations
            List<int> B = new List<int>();
            B = [1, 2];
            Console.WriteLine(basic_Task.fairRations(B));

        }
    }
}
