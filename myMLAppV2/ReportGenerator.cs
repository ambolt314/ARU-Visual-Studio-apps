using MyMLAppV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myMLAppV2
{
    public class ReportGenerator
    {
        public static String getSentimentPrediction(string txt)
        {
            var testData = new SentimentModel.ModelInput()
            {
                Col0 = txt
            };

            var result = SentimentModel.Predict(testData);
            return result.PredictedLabel == 1 ? "positive" : "negative";
        }
    }
}
