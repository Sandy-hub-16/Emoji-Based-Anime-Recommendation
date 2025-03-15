
using System.Text;

namespace Napiza_Project
{
    internal class Program
    {
        static string[] emojis = { "[A]Like",
                            "[B]Heart",
                            "[C]Laugh",
                            "[D]Wow",
                            "[E]Sad",
                            "[F]Angry",
                            "[G]RANDOM",
                            "\n[X] EXIT"
                            };
        static void Main(string[] args)
        {
            Console.WriteLine("Emoji-based Anime Series Recommendation");
            Console.WriteLine("The Recommendation is limited to 3 only (temporary)");

            Console.WriteLine();

            string userName;

            do
            {
                Console.Write("Enter Username : ");
                userName = Console.ReadLine();

                if (string.IsNullOrEmpty(userName))
                {
                    Console.WriteLine("Username cannot be empty. Please Try Again.");
                }
            } while (string.IsNullOrEmpty(userName));

            Console.WriteLine($"Konnichiwa, {userName}!, How are you feeling today?");

            DisplayEmoji();
            


            Console.Write("Enter Emoji : ");
            string userInput = GetUserEmoji();

            while (userInput != "x".ToLower())
            {
                switch (userInput.ToLower())
                {
                    case "a":
                        SetAnimeSeriesList("Like", "One Piece", "Naruto Shippuden", "Dragonball");
                        break;
                    case "b":
                        SetAnimeSeriesList("Heart", "Kimi Ni Todoke", "Kaguya-sama: Love Is War", "Fruits Basket");
                        break;
                    case "c":
                        SetAnimeSeriesList("Laugh", "Mashle: Magic And Muscles", "Dandadan", "KonoSuba");
                        break;
                    case "d":
                        SetAnimeSeriesList("Wow", "Solo Leveling", "Frieren: Beyond Journey's End", "Jujutsu Kaisen");
                        break;
                    case "e":
                        SetAnimeSeriesList("Sad", "A Silent Voice", "Your Lie in April", "Anohana: The Flower We Saw That Day");
                        break;
                    case "f":
                        SetAnimeSeriesList("Angry", "Attack on Titan", "One Punch Man", "Vinland Saga");
                        break;
                    case "g":
                        SetAnimeSeriesList("Random", "Steins Gate", "Erased", "Black Clover");
                        break;

                    default:
                        Console.WriteLine("Please enter the existing letters only");
                        break;
                }

                DisplayEmoji();
                userInput = GetUserEmoji();



                if (userInput == "x".ToLower()) 
                {
                    Console.WriteLine("Goodbye! See you in the next episode!");
                    break;
                }


            }
             


            }

        public static void SetAnimeSeriesList(string emoji, string s1, string s2, string s3) // static >> no need to instantiate
        {
            Console.WriteLine();
            Console.WriteLine($"Here are our Recommendations : ( {emoji} Emoji ) ");
            Console.WriteLine($"1. {s1}");
            Console.WriteLine($"2. {s2}");
            Console.WriteLine($"3. {s3}");
            Console.Write($"{Environment.NewLine}");
            Console.WriteLine("************************************");
            Console.WriteLine("Do you want to select again?");

        }

        public static void DisplayEmoji()
        {
           
            Console.WriteLine("Emojis : ");
            foreach (string emoji in emojis)
            {
                Console.WriteLine(emoji);
            }
        }

        public static string GetUserEmoji()
        {
            Console.Write("Enter Emoji : ");
            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
