using MoveIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MoveIt.Desktop.Receiver
{
    public class RateReceiver
    {
        public async Task<double> CalculateRate(MovementModel model)
        {
            string path = "rate";

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri(Properties.Settings.Default.APIAddress);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.PostAsJsonAsync(path, model);
            response.EnsureSuccessStatusCode();

            double rate = 0;

            if (response.IsSuccessStatusCode)
            {
                rate = await response.Content.ReadAsAsync<double>();
            }

            return rate;
        }
    }
}
