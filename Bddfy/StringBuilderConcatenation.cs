using System.Text;
using TestStack.BDDfy;
using TestStack.BDDfy.Xunit;
using Xunit;

namespace Bddfy
{
    [Story(
        AsA = "As a developer",
        IWant = "I want to join two strings together",
        SoThat = "So that they concatenated")]
    public class StringBuilderConcatenation
    {
        private StringBuilder _stringBuilder;

        [Given]
        private void Given_a_new_StringBuilder()
        {
            _stringBuilder = new StringBuilder();
        }

        [When]
        private void When_abc_is_appended()
        {
            _stringBuilder.Append("abc");
        }

        [AndWhen]
        private void And_123_is_appended()
        {
            _stringBuilder.Append("123");
        }

        [Then]
        private void Then_ToString_Equals_abc123()
        {
            Assert.Equal("abc123", _stringBuilder.ToString());
        }

        [BddfyFact]
        public void StringBuilderJoinsTwoStrings()
        {
            this.BDDfy();
        }
    }
}
