using MoveIt.BusinessLogic.Extensions;
using System;
using System.Windows.Forms;

namespace MoveIt.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double distance = 0;
            double ordinaryVolume = 0;
            double atticVolume = 0;

            double.TryParse(tbDistance.Text, out distance);
            double.TryParse(tbVolume.Text, out ordinaryVolume);
            double.TryParse(tbAtticVolume.Text, out atticVolume);

            var movementProcessor = distance.CreateMovement();

            double rate = movementProcessor.GetRate(ordinaryVolume, atticVolume, cbPiano.Checked);

            lblCalculatedRate.Text = rate.ToString();
        }
    }
}
