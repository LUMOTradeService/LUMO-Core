using LUMO.Core.Formatters;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LUMO.Core.Tests
{
    public class StringFormatterTests
    {
        [Theory]
        [InlineData("lana", "Lana")]
        [InlineData("ivan", "Ivan")]
        [InlineData("Thomas", "Thomas")]
        [InlineData("", "Value cannot be empty. (Parameter 'value')")]
        [InlineData(null, "Value cannot be null. (Parameter 'value')")]
        public void Test1(string value, string expectedResult)
        {
            var result = "";
            try
            {
                result = StringFormatter.FirstCharToUpper(value);
            }
            catch(Exception e)
            {
                result = e.Message;
            }
            Assert.Equal(expectedResult, result);
        }
    }
}
