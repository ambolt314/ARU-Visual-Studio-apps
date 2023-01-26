using MyMLAppV2;



try
{
	Console.WriteLine("Please enter a review: ");
    var input = Console.ReadLine();

	var sampleData = new SentimentModel.ModelInput()
	{
		Col0 = input
	};

	var result = SentimentModel.Predict(sampleData);
	var sentiment = (result.PredictedLabel == 1 ? "positive" : "negative");
	Console.WriteLine($"Your review was determined to be {sentiment}\n [{String.Join(",", result.Score)}]");
	//Console.WriteLine("Press any key to exit");
	Console.ReadKey();
}
catch (Exception)
{

	throw;
}
