using DevExpress.Xpo.DB;
using DevExpress.Xpo.Metadata;
using DevExpress.Xpo;
using Xunit;
using WinAppAutomation.Module.BusinessObjects;

namespace WinAppAutomation.Tests

{
    public class IsAdult_ShouldReturnTrue_WhenAgeIs18OrMore
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var dictionary = new ReflectionDictionary();
            dictionary.GetDataStoreSchema(typeof(Person)); // Load the schema
            var dataLayer = new SimpleDataLayer(dictionary, new InMemoryDataStore());
            var session = new Session(dataLayer);

            var person = new Person(session) { Name = "Alice", Age = 18 };

            // Act
            var result = person.IsAdult();

            // Assert
            Assert.True(result);
        }
    }
}