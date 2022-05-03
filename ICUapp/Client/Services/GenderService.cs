using ICUapp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;


namespace ICUapp.Client.Services
{
    public class GenderService: IGenderService
    {
        private readonly HttpClient httpClient;

        public GenderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Gender> GetGender(int genderId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Gender>> GetGenders()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<Gender>>("api/genders");
        }
    }
}
