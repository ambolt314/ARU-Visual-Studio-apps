using MyMLAppV2;

static String getSentimentPrediction(string txt)
{
	var testData = new SentimentModel.ModelInput()
	{
		Col0 = txt
	};

	var result = SentimentModel.Predict(testData);
    return result.PredictedLabel == 1 ? "positive" : "negative";
}

try
{
	Console.WriteLine("Please enter a review: ");
	var sentiment = getSentimentPrediction(Console.ReadLine());

	Console.WriteLine($"Your review was determined to be {sentiment}.");
	Console.ReadKey();
}
catch (Exception)
{

	throw;
}
