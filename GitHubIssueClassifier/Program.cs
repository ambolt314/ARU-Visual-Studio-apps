using GitHubIssueClassifier;
using System.Runtime.InteropServices;

var testData = new IssueClassifierModel.ModelInput() {
    Title = "Issue with ASP.NET",
    Description = "Cannot connect to network using ASP.NET"
};

var result = IssueClassifierModel.Predict(testData);

Console.WriteLine(result.PredictedLabel);
