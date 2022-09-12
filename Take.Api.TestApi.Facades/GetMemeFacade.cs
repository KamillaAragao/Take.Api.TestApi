using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Take.Api.TestApi.Models.MemeMaker;
using Take.Api.TestApi.Services;

namespace Take.Api.TestApi.Facades
{
    public class GetMemeFacade : IGetMemeFacade
    {
        private readonly IRest _rest;
        public GetMemeFacade(IRest rest)
        {
            _rest = rest;
        }
        public async Task<object> GetMemeAsync(string id)
        {
            var response = await _rest.GetMemeAsync(id);
            var obj = JsonConvert.SerializeObject(response);

            return obj;
        }

    }
}
