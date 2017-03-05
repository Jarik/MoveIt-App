using MoveIt.BusinessLogic.Extensions;
using MoveIt.BusinessLogic.Services;
using MoveIt.BusinessLogic.Services.Implementation;
using MoveIt.Desktop.Receiver;
using MoveIt.Models;
using System;
using System.Windows.Forms;

namespace MoveIt.Desktop
{
    public partial class Form1 : Form
    {
        // IT ISN'T DI - Time limitation

        public IVolumeService VolumeService = new VolumeService();

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

            var volume = this.VolumeService.GetTotalVolume(ordinaryVolume, atticVolume);

            double rate = movementProcessor.GetRate(volume, cbPiano.Checked);

            lblCalculatedRate.Text = rate.ToString();
        }

        private async void btnCalcByAPI_Click(object sender, EventArgs e)
        {
            RateReceiver receiver = new RateReceiver();

            double distance = 0;
            double ordinaryVolume = 0;
            double atticVolume = 0;

            double.TryParse(tbAPIDistance.Text, out distance);
            double.TryParse(tbAPIBaseVolume.Text, out ordinaryVolume);
            double.TryParse(tbAPIAtticVolume.Text, out atticVolume);

            var model = new MovementModel
            {
                AtticVolume = atticVolume,
                Distance = distance,
                OrdinaryVolume = ordinaryVolume,
                Piano = cbAPIPiano.Checked
            };

            try
            {
                var rate = await receiver.CalculateRate(model);

                lblAPIRate.Text = rate.ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
