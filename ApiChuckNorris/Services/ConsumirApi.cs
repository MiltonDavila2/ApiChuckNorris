using ApiChuckNorris.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiChuckNorris.Services
{
    public class ConsumirApi
    {
        private readonly HttpClient _client;

        public ConsumirApi()
        {
            _client = new HttpClient();
        }

        public async Task<ChuckNorrisChiste> GetChisteAsync()
        {

            ChuckNorrisChiste chuckNorrisChiste = null;

            var chiste = await _client.GetStringAsync("https://api.chucknorris.io/jokes/random");
            var ChisteRandomJson =  JsonConvert.DeserializeObject<ChuckNorrisChiste>(chiste, new JsonSerializerSettings
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
            }
             );

            if(ChisteRandomJson != null )
            {
                chuckNorrisChiste= ChisteRandomJson;
            }


            return chuckNorrisChiste;
        }


    }
}
