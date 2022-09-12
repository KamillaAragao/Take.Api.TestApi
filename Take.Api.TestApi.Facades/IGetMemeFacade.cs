using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Take.Api.TestApi.Models.MemeMaker;

namespace Take.Api.TestApi.Facades
{
    public interface IGetMemeFacade
    {
        Task<object> GetMemeAsync(string id);
    }
}
