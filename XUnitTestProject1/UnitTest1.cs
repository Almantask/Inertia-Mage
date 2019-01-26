using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace XUnitTestProject1
{
    public class LevelNaviationTests
    {
        [Fact]
        public void NextLevelFirst()
        {
            var dummyLevel = new Level();
            var levels = new List<Level>() {dummyLevel, dummyLevel};
            var game = new Game(levels);

            game.GoToNextLevel();

            var expected = 1;
            var actual = game.LevelIndex;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NextLevelLast()
        {
            var dummyLevel = new Level();
            var levels = new List<Level>() {dummyLevel};
            var game = new Game(levels);

            Assert.Throws<NoMoreLevelsException>(() => game.GoToNextLevel());
        }

        [Fact]
        public void Test()
        {
            var a = 5;
            var b = 6;
            var c = false;
            Console.WriteLine(c ? $"{a}>{b}={a > b}" : "No comparison");

            var levels = new List<Level>();
            var game = new Game(levels);
        }
    }

    public class Game
    {
        public int LevelIndex { private set; get; }
        private readonly List<Level> _levels;
        private Level _levelCurrent;

        public Game(List<Level> levels)
        {
            _levels = levels;
        }

        public void GoToNextLevel()
        {
            var nextLevel = LevelIndex + 1;
            GoToLevel(nextLevel);
            GoToLevelBad(nextLevel);
        }

        public void GoToLevel(int index)
        {
            if (index < _levels.Count)
            {
                _levelCurrent = _levels[index];
                LevelIndex = index;
            }
            else
            {
                throw new NoMoreLevelsException();
            }
            GoToNextLevelBad();
        }

        public void GoToLevelBad(int index)
        {
            _levelCurrent = _levels[index];
            LevelIndex = index;
        }

        public void GoToNextLevelBad()
        {
            if (LevelIndex + 1 < _levels.Count)
            {
                GoToLevelBad(LevelIndex + 1);
            }
        }
    }

    public class NoMoreLevelsException : Exception
    {
    }

    public class Level
    {
    }

    public class PhoneNumber
    {
        private readonly string countryCode;

        public string PhoneDigits { get; }
        public string PhoneCountry => countryCode + PhoneDigits;

        protected PhoneNumber(string phone)
        {
            if(string.IsNullOrWhiteSpace(phone))
                throw new InvalidPhoneException("Not enough info for phone");
            var invalidSymbols = phone.Where(char.IsLetter);
            if(invalidSymbols.Any())
            {
                throw new InvalidPhoneException(invalidSymbols);
            }

            PhoneDigits = phone;
        }
    }

    public class LithuanianPhoneNumber:PhoneNumber
    {
        private const string countryCode = "+370";
        public LithuanianPhoneNumber(string phone) : base(phone)
        {
        }
    }



    public class InvalidPhoneException : Exception
    {
        public InvalidPhoneException(IEnumerable<char> invalidSymbols)
        {
            throw new NotImplementedException();
        }
    }

    enum OrderType { Sales, Purchase}

    class BusinessProcessor
    {
        private readonly Dictionary<OrderType, IBusinessAction> _actions;

        public BusinessProcessor(Dictionary<OrderType, IBusinessAction> actions)
        {
            _actions = actions;
        }

        public void Process(Order order)
        {
            if(_actions.ContainsKey(order.Type))
                _actions[order.Type].Execute();
        }

    }

    interface IBusinessAction
    {
        void Execute();
    }

    class SalesAction : IBusinessAction
    {
        public void Execute()
        {
            
        }
    }

    class PurhcaseAction : IBusinessAction
    {
        public void Execute()
        {
            
        }
    }




    class Order
    {
        public Item Item { get; }
        public DateTime DateTime { get; }

        public OrderType Type { set; get; }
        public Order(Item item, OrderType type)
        {
            if (Item == null)
                throw new NoOrderTargetFound();

            Type = type;
            Item = item;
            DateTime = new DateTime();
        }


    }

    internal class NoOrderTargetFound : Exception
    {
    }

    internal class Item
    {
    }
}
