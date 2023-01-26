using System;

namespace myMLApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a review: ...");
            var input = Console.ReadLine();


            try
            {
                ModelInput sampleData = new ModelInput()
                {
                    Col0 = input
                };

                ModelOutput result = SentimentModel.Predict(sampleData);

                Console.WriteLine($"Predicting sentiment of {sampleData}...");
                string sentiment = (result == 1 ? "positive" : "negative");
                Console.WriteLine($"Your review was {sentiment}");
                Console.WriteLine("Press any key to quit");
                Console.ReadKey();


            }
            catch (Exception)
            {

                Console.WriteLine("### Something went wrong ###");
            }

        }
    }
}


