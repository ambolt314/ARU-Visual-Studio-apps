namespace TaxiFarePredictor
{
    public partial class frmTaxiFarePredictor : Form
    {
        public frmTaxiFarePredictor()
        {
            InitializeComponent();
        }

        private void btnPredictFare_Click(object sender, EventArgs e)
        {
            try {
                var sampleData = new PricePredictionModel.ModelInput()
                {
                    Trip_time_in_secs = float.Parse(txtTime.Text),
                    Trip_distance = float.Parse(txtDistance.Text),
                };

                var result = PricePredictionModel.Predict(sampleData);

                lblPredictedFare.Text = $"Predicted fare: ${Math.Round(result.Score, 2)}";
            }
            catch (Exception)
            {
                lblPredictedFare.Text = "Unable to predict fare";
            }
            finally
            {
                lblPredictedFare.Visible = true;
            }
            

        }
    }
}