using System;
using Newtonsoft.Json;

namespace FInalAssignmentAPI
{
    public class Data
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("confirmed_cases")]
        public long ConfirmedCases { get; set; }

        [JsonProperty("probable_cases")]
        public long ProbableCases { get; set; }

        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }
    }
}
