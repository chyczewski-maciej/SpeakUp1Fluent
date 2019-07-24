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
    public class FluentStringBuilderConcatenation
    {
        private StringBuilder _stringBuilder;

        [BddfyFact]
        public void StringBuilderJoinsTwoStrings()
        {
            this.Given(fluentStringBuilderConcatenation => fluentStringBuilderConcatenation.A_new_StringBuilder())
                .When(_ => Abc_is_appended())
                .And(_ => _123_is_appended(), "And 123 is appended")
                .Then(_ => ToString_Equals_abc123())
                .BDDfy();
        }

        private void A_new_StringBuilder() => _stringBuilder = new StringBuilder();
        private void Abc_is_appended() => _stringBuilder.Append("abc");
        private void _123_is_appended() => _stringBuilder.Append("123");
        private void ToString_Equals_abc123() => Assert.Equal("abc123", _stringBuilder.ToString());
    }
}
