using Xunit;

namespace ExampleWebTest
{
    public class ExampleTest : TestOperator
    {
        [Theory]
        [InlineData ("sweet kittens")]
        [InlineData ("memes")]
        [InlineData ("work stuff")]
        private void TestMethod(string phrase)
        {
            //Act
            var googleMainPage = new GoogleMainPage(Driver);
            //Arrange
            ResultPage resultPage = googleMainPage.SearchForPhrase(phrase);
            //Assert
            Assert.True(resultPage.AreResultsLoaded());
        }
    }
}
