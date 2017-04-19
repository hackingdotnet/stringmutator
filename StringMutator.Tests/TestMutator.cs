using System;
using Xunit;
using StringMutator.Extension;

namespace StringMutator.Tests
{
    public class TestMutator
    {
        [Fact]
        public void Can_Chop_Lines()
        {
            string welcome = "Welcome to the\nString Mutator.";

            Assert.Equal(2, welcome.Lines().Length);
        }

        [Fact]
        public void Can_Capitalize_First_Word()
        {
            // Arrange

            string welcome = "welcome to the string mutator.";
            string expected = "Welcome to the string mutator.";

            // Act
            var actual = welcome.Capitalize();

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Can_Return_Titleized_String()
        {            
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = "Lorem Ipsum Dolor";
            //Act
            var actual = primer.Titleize();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Return_Words()
        {
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = new string[] { "lorem", "ipsum", "dolor" };
            //Act
            var actual = primer.Words();
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Can_Return_Characters()
        {
            //Arrange
            var primer = "lorem";
            var expected = new char[] { 'l', 'o', 'r', 'e', 'm' };
            //Act
            var actual = primer.Characters();
            //Assert
            Assert.Equal(expected, actual);
        }
    
        [Fact]
        public void Can_Return_Chop()
        {
            //Arrange
            var primer = "lorem ipsum dolor"; // 17 char's
            var expected = new string[] { "lore", "m ip", "sum ", "dolo", "r" };
            //Act
            var actual = primer.Chop(4); // chop into 4 chars elements array 
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
