using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RandomDataToolsInterop.Models;

namespace RandomDataToolsInterop
{
    public static class Api
    {
        private static readonly HttpClient _httpClient = new();

        private const string ServerUri = "https://api.randomdatatools.ru";

        private static DateTime? _latestRequestUtcTime;
        private const int RequestsInterval = 1000;

        private static readonly Semaphore _httpRequestSemaphore = new(1, 1);

        private static async Task<List<PersonRawInfo>> GetPersonRawInfoAsync(int count, Gender gender = null)
        {
            _httpRequestSemaphore.WaitOne();
            
            if (count is < 0 or > 100)
            {
                _httpRequestSemaphore.Release();
                throw new ArgumentException("Persons count cannot be less than 0 or more than 100", nameof(count));
            }

            var genderParameter = gender?.Code ?? "unset";

            var json = await _httpClient.GetStringAsync($"{ServerUri}?count={count}&gender={genderParameter}");
            _latestRequestUtcTime = DateTime.UtcNow;
            
            #pragma warning disable 4014
            
            //Ждём 1 секунду, прежде чем разрешить сделать следующий запрос, для избежания TooManyRequests.
            //Не используем await, ожидание не нужно.
            Task.Run(() =>
            {
                while (Math.Abs(DateTime.UtcNow.Subtract(_latestRequestUtcTime.Value).TotalMilliseconds) < RequestsInterval) { }
                _httpRequestSemaphore.Release();
            });
            
            #pragma warning restore 4014
            
            try
            {
                var result = count == 1 
                    ? new List<PersonRawInfo> { JsonConvert.DeserializeObject<PersonRawInfo>(json) }
                    : JsonConvert.DeserializeObject<List<PersonRawInfo>>(json);

                var exception = GetRequestException(json);
                if (exception != null)
                {
                    throw exception;
                }

                return result;
            }
            catch (JsonSerializationException)
            {
                throw GetRequestException(json);
            }
        }

        private static HttpRequestException GetRequestException(string responseJson)
        {
            try
            {
                var error = JsonConvert.DeserializeObject<ErrorResult>(responseJson);
                if (error?.IsEmpty() is true or null)
                {
                    return null;
                }
                var exception = new HttpRequestException($"{error.ErrorCode} \"{error.ErrorMessage}\"");
                exception.Data["StatusCode"] = error.ErrorCode;
                exception.Data["ErrorMessage"] = error.ErrorMessage;
                _httpRequestSemaphore.Release();
                return exception;
            }
            catch (JsonSerializationException)
            {
                return null;
            }
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
            var task = GetPersonAsync(gender);
            var result = task
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            
            return result;
        }

        public static List<Person> GetPeople(int count, Gender gender = null)
        {
            var task = GetPeopleAsync(count, gender);
            var result = task
                .ConfigureAwait(false)
                .GetAwaiter()
                .GetResult();
            
            return result;
        }
    }
}