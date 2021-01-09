using System;
using TestRules;
using Xunit;

namespace XUnitTestProject1
{
    public class Person_Tests
    {
        [Theory]
        [InlineData(720, "Florida")]
        public void Create(int credit_score, string state)
        {
            Person person = new Person(credit_score, state);
            Assert.Equal(credit_score, person.credit_score);
            Assert.Equal(state, person.state);
        }
    }
}
