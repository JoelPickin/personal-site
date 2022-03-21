using RoadToSolo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoadToSolo.Pages
{
    public partial class SubscribeForm
    {
        private Subscriber subscriber = new Subscriber();
        private static readonly HttpClient client = new HttpClient();
        private bool IsSubscribed { get; set; }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        private async Task AddSubscriber()
        {
            var values = new Dictionary<string, string>
            {
                {"api_key", "65NMwQO81hJc7Em002CDig" },
                {"name", subscriber.FirstName},
                {"email", subscriber.Email }
            };

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("https://api.convertkit.com/v3/forms/3058195/subscribe", content);

            var responseString = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                IsSubscribed = true;
            }
        }
    }
}
