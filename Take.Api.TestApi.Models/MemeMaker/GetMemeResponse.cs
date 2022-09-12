using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Take.Api.TestApi.Models.MemeMaker
{
    public class GetMemeResponse
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("data")]
        public GetMemeResponseData GetMemeResponseData { get; set; }
    }
}
