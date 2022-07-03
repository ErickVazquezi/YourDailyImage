using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.IO;
using YourDailyPic.Models;

namespace YourDailyPic.Services
{
    public class ImageService
    {
        private const string PexelsEndPoint = "https://api.pexels.com/v1/";
        public ImageService()
        {

        }

        public async Task<PexelsImage> GetImages(string topic)
        {
            PexelsImage image = new PexelsImage();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(PexelsEndPoint);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(Resources.ApiKey);

            HttpResponseMessage response = await client.GetAsync($"search?query={topic}&per_page=1");
            if (response.IsSuccessStatusCode)
            {
                var responseData = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<PexelsResponse>(responseData);
                image = Items.photos[0];
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            return image;
        }
    }
}
