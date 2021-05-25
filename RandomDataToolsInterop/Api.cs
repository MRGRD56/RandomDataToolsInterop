using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RandomDataToolsInterop.Models;

namespace RandomDataToolsInterop
{
    public static class Api
    {
        private static readonly HttpClient _httpClient = new();

        private const string ServerUri = "https://api.randomdatatools.ru";

        private static async Task<List<PersonRawInfo>> GetPersonRawInfoAsync(int count, Gender gender = null)
        {
            if (count is < 0 or > 100)
            {
                throw new ArgumentException("Persons count cannot be less than 0 and more than 100", nameof(count));
            }

            var genderParameter = gender?.Code ?? "unset";

            var json = await _httpClient.GetStringAsync($"{ServerUri}?count={count}&gender={genderParameter}");
            return count == 1 
                ? new List<PersonRawInfo> { JsonConvert.DeserializeObject<PersonRawInfo>(json) }
                : JsonConvert.DeserializeObject<List<PersonRawInfo>>(json);
        }

        public static async Task<Person> GetPersonAsync(Gender gender = null)
        {
            var people = await GetPersonRawInfoAsync(1, gender);
            var firstPersonRawInfo = people.SingleOrDefault();
            return Person.FromRawInfo(firstPersonRawInfo);
        }

        public static async Task<List<Person>> GetPeopleAsync(int count, Gender gender = null)
        {
            var people = await GetPersonRawInfoAsync(count, gender);
            return people.Select(Person.FromRawInfo).ToList();
        }

        public static Person GetPerson(Gender gender = null)
        {
            return GetPersonAsync(gender)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }

        public static List<Person> GetPeople(int count, Gender gender = null)
        {
            return GetPeopleAsync(count, gender)
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
        }
    }
}