namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you favorite subject in school?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "english":
                    Console.WriteLine("I acually love to read!");
                    break;
                case "math":
                    Console.WriteLine("What are you crazy?!");
                    break;
                case "science":
                    Console.WriteLine("You might end up saving the world learning that!");
                    break;
                case "history":
                    Console.WriteLine("Most of it is revised... In a bad way.");
                    break;
                case "art":
                    Console.WriteLine("They still teaching that in school?");
                    break;
                default:
                    Console.WriteLine("You must not of picked on that actually matters.");
                    break;
            }

        }
    }
}