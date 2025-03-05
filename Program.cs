
using System.Text;

namespace Napiza_Project
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Emoji-based Anime Series Recommendation");
            Console.WriteLine("The Recommendation is limited to 3 only (temporary)");

            Console.WriteLine();

            Console.Write("Enter Username : ");
            string userName = Console.ReadLine();


            if (!string.IsNullOrEmpty(userName))
            {
                string[] emojis = { "[A]Like",
                                    "[B]Heart",
                                    "[C]Laugh",
                                    "[D]Wow",
                                    "[E]Sad",
                                    "[F]Angry",
                                    "[G]RANDOM",
                                    "\n[X] EXIT"
                                  };
                Console.WriteLine($"Hello {userName}!, How are you feeling today?");

                while (true)
                {
                    foreach (string emoji in emojis)
                    {

                        Console.WriteLine(emoji);
                    }

                    string userInput = Console.ReadLine();

                    string[] input = { "a", "b", "c", "d", "e", "f", "g", "x" };


                    if (!string.IsNullOrEmpty(userInput))
                    {
                        if (input.Contains(userInput.ToLower()))
                        {
                            switch (userInput.ToString().ToLower())
                            {
                                case "a":
                                    AnimeSeriesList("Like", "One Piece", "Naruto Shippuden", "Dragonball");
                                    break;
                                case "b":
                                    AnimeSeriesList("Heart", "Kimi Ni Todoke", "Kaguya-sama: Love Is War", "Fruits Basket");
                                    break;
                                case "c":
                                    AnimeSeriesList("Laugh", "Mashle: Magic And Muscles", "Dandadan", "KonoSuba");
                                    break;
                                case "d":
                                    AnimeSeriesList("Wow", "Solo Leveling", "Frieren: Beyond Journey's End", "Jujutsu Kaisen");
                                    break;
                                case "e":
                                    AnimeSeriesList("Sad", "A Silent Voice", "Your Lie in April", "Anohana: The Flower We Saw That Day");
                                    break;
                                case "f":
                                    AnimeSeriesList("Angry", "Attack on Titan", "One Punch Man", "Vinland Saga");
                                    break;
                                case "g":
                                    AnimeSeriesList("Random", "Steins Gate", "Erased", "Black Clover");
                                    break;

                                default:
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine($"Try Again.{Environment.NewLine}Select only the available letters.");
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input cannot be empty.");
                    }




                    if (userInput.ToString().ToLower() == "x")
                    {
                        Console.OutputEncoding = Encoding.UTF8;
                        Console.WriteLine("Goodbye! See you in the next episode!");
                        break;
                    }

                }

            }
            else
            {
                Console.WriteLine("Username cannot be Empty.");
            }
        }

        public static void AnimeSeriesList(string emoji, string s1, string s2, string s3) // static >> no need to instantiate
        {
            Console.WriteLine($"Here are our Recommendations : ( {emoji} Emoji ) ");
            Console.WriteLine($"1. {s1}");
            Console.WriteLine($"2. {s2}");
            Console.WriteLine($"3. {s3}");
            Console.Write($"{Environment.NewLine}");
            Console.WriteLine("Do you want to select again?");
        }
    }
}
