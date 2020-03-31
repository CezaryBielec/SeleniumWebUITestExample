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
            //Arrange
            var googleMainPage = new GoogleMainPage(Driver);
            //Act
            ResultPage resultPage = googleMainPage.SearchForPhrase(phrase);
            //Assert
            Assert.True(resultPage.AreResultsLoaded());
        }
    }
}
