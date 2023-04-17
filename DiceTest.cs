namespace Dices.Tests
{
    public class DiceTest
    {
        private Dice? dice;

        [Theory]
        [InlineData(DiceType.D4)]
        [InlineData(DiceType.D6)]
        [InlineData(DiceType.D8)]
        [InlineData(DiceType.D10)]
        [InlineData(DiceType.D12)]
        [InlineData(DiceType.D20)]
        [InlineData(DiceType.D100)]
        public void DiceThrowOutputGraterThen0ShouldReturnTrue(DiceType diceType)
        {
            dice = new Dice(diceType);

            var result = dice.Throw();

            Assert.True(result > 0);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(6)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(12)]
        [InlineData(20)]
        [InlineData(47)]
        [InlineData(69)]
        [InlineData(100)]
        public void DiceThrowOutputGratherThen0AndLessThenDiceSidesNumberShouldReturnTrue(uint diceSides)
        {
            dice = new Dice();

            var result = dice.Throw(diceSides);

            Assert.True(result > 0 && result <= diceSides);
        }

        [Theory]
        [InlineData(DiceType.D4, -10)]
        [InlineData(DiceType.D6,-10)]
        public void DiceThrowWithModifierShouldBeNegatvieNumber(DiceType diceType, int modifier)
        {
            dice = new Dice(diceType);

            var result = dice.Throw(modifier);

            Assert.True(result < 0);
        }
    }
}