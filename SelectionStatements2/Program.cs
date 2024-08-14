namespace SelectionStatements2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Number Guessing Game
            /*var r = new Random();
            var favNumber = r.Next(0, 100);

            Console.WriteLine("Pick a number between 0 - 100");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }*/

            //Switch-Case
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Cool! We use math in daily life.");
                    break;
                case "science":
                    Console.WriteLine("Sweet. Careful with those bubbling beakers.");
                    break;
                case "pe":
                    Console.WriteLine("Fun and sweaty!");
                        break;
                case "history":
                    Console.WriteLine("Ah, yes. The stories are forever to be told.");
                    break;
                case "english":
                    Console.WriteLine("Fabulous!");
                    break;
                default:
                    Console.WriteLine("I don't know that subject.");
                    break;

            }
        }
    }
}
