using myMLAppV2;
using MyMLAppV2;

try
{
	Console.WriteLine("Please enter a review: ");
	var sentiment = ReportGenerator.getSentimentPrediction(Console.ReadLine());

	Console.WriteLine($"Your review was determined to be {sentiment}.");
	Console.ReadKey();
}
catch (Exception)
{

	throw;
}

