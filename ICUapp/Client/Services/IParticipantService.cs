using ICUapp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace ICUapp.Client.Services
{
   public interface IParticipantService
    {
        //Task<IEnumerable<Participant>> Search(string name, Gender? gender);
        Task<IEnumerable<Participant>> GetParticipants();
        Task<Participant> GetParticipant(int employeeId);
        //int GetdeptIdByParticipantNo(string ParticipantNo);
        //Task<Participant> GetParticipantByEmail(string email);
        Task<Participant> AddParticipant(Participant employee);
        Task<Participant> UpdateParticipant(Participant employee);
        Task<string> UploadImage(MultipartFormDataContent content);
        Task DeleteParticipant(int employeeId);
    }
}


