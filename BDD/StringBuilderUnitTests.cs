using FluentAssertions;
using System.Text;
using Xunit;
using static BddExtensions.Core;

namespace BDD
{
    public class StringBuilderUnitTests
    {
        [Fact]
        public void StringBuilderJoinsTwoStrings()
        {
            Given(new StringBuilder())
                .When(AbcAppended)
                .AndWhen(_123Appended)
                .Then(ToStringEqualsAbc123);




            void AbcAppended(StringBuilder stringBuilder)
                => stringBuilder.Append("Abc");

            // ReSharper disable once InconsistentNaming
            void _123Appended(StringBuilder stringBuilder)
                => stringBuilder.Append("123");

            void ToStringEqualsAbc123(StringBuilder stringBuilder)
                => stringBuilder.ToString().Should().Be("Abc123");
        }
    }
}
