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
    }
}