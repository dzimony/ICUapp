using ICUapp.Shared;
//using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ICUapp.Client.Services
{
    public class ParticipantfService : IParticipantService
    {
        private readonly HttpClient httpClient;

        public ParticipantfService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        //public Task<Participant> AddParticipant(Participant employee)
        //{
        //    throw new NotImplementedException();
        //}
        public async Task<Participant> AddParticipant(Participant newParticipant)
        {
            Console.Write("I am called");
            var response = await httpClient.PostAsJsonAsync("api/Participants", newParticipant);
            Console.Write(response);

            return await response.Content.ReadFromJsonAsync<Participant>();
        }
        public async Task DeleteParticipant(int ParticipantId)
        {
            await httpClient.DeleteAsync("api/Participants/" + ParticipantId);
        }

        //public int GetdeptIdByParticipantNo(string ParticipantNo)
        //{
        //    return httpClient.GetFromJsonAsync<int>("api/Participants/" + ParticipantNo);
        //}
        public async Task<Participant> GetParticipant(int ParticipantId)
        {
            return await httpClient.GetFromJsonAsync<Participant>("api/Participants/" + ParticipantId);
        }

        public Task<Participant> GetParticipantByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Participant>> GetParticipants()
        {

            return await httpClient.GetFromJsonAsync<IEnumerable<Participant>>("api/Participants");

        }

        //public Task<IEnumerable<Participant>> Search(string name, Gender gender)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Participant> UpdateParticipant(Participant newParticipant)
        {
            var response = await httpClient.PutAsJsonAsync("api/Participants", newParticipant);  
            return await response.Content.ReadFromJsonAsync<Participant>();
        }

        public async Task<string> UploadImage(MultipartFormDataContent content)
        {
            
            Console.WriteLine("I am called");
           // var docandfolder = new { image = content, folderName = folderName };
            //var data = JsonConvert.SerializeObject(docandfolder);
            var postResult = await httpClient.PostAsync($"api/uploads",content);
            var postContent = await postResult.Content.ReadAsStringAsync();
            if (!postResult.IsSuccessStatusCode)
            {
                throw new ApplicationException(postContent);
            }
            else
            {
                
                var imgUrl = postContent;
                return imgUrl;
            }
        }

        
    }
}

