using NSubstitute;
using Xunit;

namespace MyLib.UnitTests
{
    public class Class1Tests
    {
        [Fact]
        public void GoBug_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var subEmployee = Substitute.For<IEmployee>();
            subEmployee.Get().Returns(new Employee()
            {
                Id = 1,
                Name = "Bob"
            });

            var unitUnderTest = new Class1(subEmployee);

            // Act
            unitUnderTest.GoBug();

            // Assert
            Assert.True(false);
        }
    }
}