using FluentAssertions;
using System.Text;
using Xunit;
using static BDD.BddExtensions;
// ReSharper disable InconsistentNaming

namespace BDD
{
    public class StringBuilderUnitTests
    {
        [Fact]
        public void StringBuilderJoinsTwoStrings()
        {
            Given(new StringBuilder())
                .When(Abc_appended)
                .AndWhen(_123_appended)
                .Then(StringBuilder_ToString_returns_Abc123);

            void Abc_appended(StringBuilder stringBuilder) => stringBuilder.Append("Abc");

            // ReSharper disable once InconsistentNaming
            void _123_appended(StringBuilder stringBuilder) => stringBuilder.Append("123");

            void StringBuilder_ToString_returns_Abc123(StringBuilder stringBuilder)
                => stringBuilder.ToString().Should().Be("Abc123");
        }
    }
}
