using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RandomDataToolsInterop.Tests
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetPersonAsyncTest()
        {
            var person = await RandomDataTools.GetPersonAsync();
            Assert.NotNull(person);
        }
        
        [Test]
        public async Task GetPeopleAsyncTest()
        {
            const int count = 100;
            var people = await RandomDataTools.GetPeopleAsync(count);
            Assert.NotNull(people);
            Assert.AreEqual(count, people.Count);
        }
        
        [Test]
        public void GetPersonTest()
        {
            var person = RandomDataTools.GetPerson();
            Assert.NotNull(person);
        }
        
        [Test]
        public void GetPeopleTest()
        {
            const int count = 100;
            var people = RandomDataTools.GetPeople(count);
            Assert.NotNull(people);
            Assert.AreEqual(count, people.Count);
        }

        [Test]
        public async Task TooManyRequestsTest()
        {
            try
            {
                await RandomDataTools.GetPersonAsync();
                await RandomDataTools.GetPersonAsync();
                await RandomDataTools.GetPersonAsync();
            }
            catch (HttpRequestException exception)
            {
                Assert.Fail(exception.Message);
            }
        }
    }
}