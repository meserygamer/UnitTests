using CalculatorForUnitTests;
namespace CalculatorUnitTestsXunit
{
    public class UnitTestForNull
    {
        [Fact]
        public void NullTypeTest()
        {
            Assert.Null(Calculator.Singleton);
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void AllTest()
        {
            InterfaceForUser.GetInterfaceForUser().CalculateExpression(new InputExpression("2 + 3"), 1);
            InterfaceForUser.GetInterfaceForUser().CalculateExpression(new InputExpression("7 - 2"), 1);
            InterfaceForUser.GetInterfaceForUser().CalculateExpression(new InputExpression("10 / 2"), 1);
            InterfaceForUser.GetInterfaceForUser().CalculateExpression(new InputExpression("2,5 * 2"), 1);
            Assert.All(InterfaceForUser.GetInterfaceForUser().History, a => Assert.Equal('5', a[a.Length - 1]));
        }
        [Fact]
        public void ContainsTest()
        {
            InterfaceForUser.GetInterfaceForUser().CalculateExpression(new InputExpression("2 + 3"), 1);
            Assert.Contains("2 + 3 = 5", InterfaceForUser.GetInterfaceForUser().History);
        }
        [Fact]
        public void DoesNotContainsTest()
        {
            InterfaceForUser.GetInterfaceForUser().CalculateExpression(new InputExpression("10 / 2"), 1);
            Assert.DoesNotContain("10 / 2 = ", InterfaceForUser.GetInterfaceForUser().History);
        }
        [Fact]
        public void DoesNotMatchTest()
        {
            Assert.DoesNotMatch(InterfaceForUser.GetInterfaceForUser().ForProofCh, @"435,24обо");
        }
        [Fact]
        public void DoesMatchTest()
        {
            Assert.Matches(InterfaceForUser.GetInterfaceForUser().ForProofZn, @"+");
        }
        [Fact]
        public void EqualTest()
        {
            Assert.Equal(50, Calculator.GetCalculator().Multiplication(5, 10));
        }
        [Fact]
        public void NotEqualTest()
        {
            Assert.NotEqual(5, Calculator.GetCalculator().Addition(2, 2));
        }
        [Fact]
        public void TrueTest()
        {
            Assert.True(Calculator.GetCalculator().Addition(2, 2) == Calculator.GetCalculator().Division(8, 2));
        }
        [Fact]
        public void IsInstanceOfTypeTest()
        {
            Assert.IsType<InterfaceForUser>(InterfaceForUser.GetInterfaceForUser());
        }
        [Fact]
        public void IsNotInstantTypeTest()
        {
            Assert.IsNotType<int>(new InputExpression("2 + 5").numbers[0]);
        }
        [Fact]
        public void NotNullTypeTest()
        {
            Calculator.GetCalculator();
            Assert.NotNull(Calculator.Singleton);
        }
        [Fact]
        public void SameTest()
        {
            InterfaceForUser Ui = InterfaceForUser.GetInterfaceForUser();
            Assert.Same(Ui, InterfaceForUser.GetInterfaceForUser());
        }
        [Fact]
        public void NotSameTest()
        {
            InputExpression Ie = new InputExpression("2 * 2");
            Assert.NotSame(Ie, new InputExpression("2 * 2"));
        }
        [Fact]
        public void ThrowsExceptionsTest()
        {
            Assert.Throws<Exception>(() => new InputExpression("353 ] 245").ToString());
        }
    }
}