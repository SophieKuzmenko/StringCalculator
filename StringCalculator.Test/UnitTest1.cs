namespace StringCalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyArgTest()
        {
            //Given
            string input = "";

            //When
            int res = StringCalculator.Calculate(input);

            //Then
            Assert.Equal(0, res);
        }
        [Fact]
        public void SingleArgTest()
        {
            //Given
            int arg = 23;

            //When
            int res = StringCalculator.Calculate(arg.ToString());

            //Then
            Assert.Equal (arg, res);
        }
        [Fact]
        public void DoubleArgSeparatedByCommaTest()
        {
            //Given
            int arg1 = 23;
            int arg2 = 8;
            string input = "23,8";

            //When
            int res = StringCalculator.Calculate(input);

            //Then
            Assert.Equal(arg1+arg2, res);
        }
        [Fact]
        public void DoubleArgSeparatedByNewlineTest()
        {
            //Given
            int arg1 = 23;
            int arg2 = 8;
            string input = "23\n8";

            //When
            int res = StringCalculator.Calculate(input);

            //Then
            Assert.Equal(arg1 + arg2, res);
        }
    }
}