using ICUapp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICUapp.Client.Services
{
   public interface IGenderService
    {
        Task<IEnumerable<Gender>> GetGenders();
        Task<Gender> GetGender(int genderId);
    }
}
