using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Take.Api.TestApi.Models.MemeMaker;

namespace Take.Api.TestApi.Services
{
    public interface IRest
    {
        [Get("{data}")]
        Task<object> GetMemeAsync([Path] string data);
        
    }
}
