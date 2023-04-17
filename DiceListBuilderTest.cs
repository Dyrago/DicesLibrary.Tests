using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dices.Tests
{
    public class DiceListBuilderTest
    {
        private DiceListBuilder _builder;

        [Fact]
        public void AddToListDiceListShouldBeEqual5()
        {
            _builder = new DiceListBuilder();
            List<Dice> dices = new List<Dice>() { 
                new Dice(),
                new Dice()
            };

            _builder
                 .AddDiceTimes(times: 3);

            _builder.AddToList(dices);

            Assert.Equal(5, dices.Count);
        }

        [Fact]
        public void AddDiceToCollectionShouldBeEqual3()
        {
            _builder = new DiceListBuilder();
            List<Dice> dices = _builder
                                    .AddDiceTimes(times: 3)
                                    .ReturnDicesList();

            Assert.Equal(3, dices.Count);
        }

    }
}
