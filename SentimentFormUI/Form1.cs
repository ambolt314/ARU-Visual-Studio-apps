using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentimentFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String prediction = getSentimentPrediction(txtReview.Text);
            
            switch(prediction)
            {
                case "positive":
                    pnlSentiment.BackColor = Color.Green; break;
                case "negative":
                    pnlSentiment.BackColor= Color.Red; break;
            }
        }
    }
}
