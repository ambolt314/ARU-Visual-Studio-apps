using MyMLAppV2;
namespace SentimentModelUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            String prediction = myMLAppV2.ReportGenerator.getSentimentPrediction(txtReview.Text);

            if (prediction == "positive") {
                pnlSentiment.BackColor = Color.Green;
            }
            else
            {
                pnlSentiment.BackColor = Color.Red;
            }
        }
    }
}