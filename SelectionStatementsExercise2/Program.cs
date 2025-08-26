namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject(); 
        }


        public static void FavSubject()
        {
            Console.WriteLine("what is your favroite subject in school?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is tough");
                    break;

                case "science":
                    Console.WriteLine("Science is challenging since math involved");
                    break;

                case "history":
                    Console.WriteLine("History is fun, History involves real world facts");
                    break;

                case "compsci":
                    Console.WriteLine("Computer Science Rules!");
                    break;

                case "music":
                    Console.WriteLine("love making and producing, working to be the best in the business"); 
                    break;

                default:
                    Console.WriteLine("Cool,I couldn't agree any less"); 
                    break;
            }
        }
    }
}