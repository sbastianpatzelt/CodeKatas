using System;
using System.Diagnostics;
using FizzBuzz.Objects;
using Xunit;
using Xunit.Extensions;

namespace FizzBuzzKata
{
    public class FizzBuzzTests
    {
        private IFizzBuzzer f = new FizzBuzzer();
        private IFizzBuzzer f2 = new FizzBuzzerAkoNhu();

        [Theory]
        [InlineData("Fizz", 3)]
        [InlineData("Buzz", 5)]
        [InlineData("FizzBuzz", 15)]
        [InlineData("1", 1)]
        [InlineData("Fizz", 111)]
        [InlineData("Fizz", 99)]
        [InlineData("Fizz", 78)]
        [InlineData("FizzBuzz", 105)]
        [InlineData("FizzBuzz", 45)]
        [InlineData("Buzz", 25)]
        [InlineData("Buzz", 65)]
        public void FizzBuzzTest(string expected, int number)
        {
            Assert.Equal(expected, f.Get(number));
        }



        [Theory]
        [InlineData("Fizz", 3)]
        [InlineData("Buzz", 5)]
        [InlineData("FizzBuzz", 15)]
        [InlineData("1", 1)]
        [InlineData("Fizz", 111)]
        [InlineData("Fizz", 99)]
        [InlineData("Fizz", 78)]
        [InlineData("FizzBuzz", 105)]
        [InlineData("FizzBuzz", 45)]
        [InlineData("Buzz", 25)]
        [InlineData("Buzz", 65)]
        public void FizzBuzzTestWithAkoNhu(string expected, int number)
        {
            Assert.Equal(expected, f2.Get(number));
        }

        [Theory]
        [InlineData(100)]
        public void FizzBuzzConsole(int number)
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(f.Get(i));
            }
            sw.Stop();

        }

        [Theory]
        [InlineData(100)]
        public void FizzBuzzAkoNhuConsole(int number)
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(f2.Get(i));
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        [Theory]
        [InlineData(100)]
        public void FizzBuzzCompareBothConsole(int number)
        {
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < number; i++)
            {
                //Console.WriteLine(f.Get(i));
                f.Get(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);


            var sw2 = new Stopwatch();
            sw2.Start();
            for (int i = 0; i < number; i++)
            {
                //Console.WriteLine(f2.Get(i));
                f2.Get(i);
            }
            sw2.Stop();
            Console.WriteLine(sw2.Elapsed);



            Console.WriteLine((sw2.Elapsed - sw.Elapsed).TotalMilliseconds);


        }


        [Theory]
        [InlineData(10000 * 10000)]
        public void FizzBuzzCompareBothConsoleReverse(int number)
        {
            var sw = new Stopwatch();
            sw.Start();

            for (int i = number; i >= 0; i--)
            {
                f.Get(i);
            }
           
            sw.Stop();
            Console.WriteLine(sw.Elapsed);


            var sw2 = new Stopwatch();
            sw2.Start();
            for (int i = number; i >= 0; i--)
            {
                f2.Get(i);
            }
            sw2.Stop();
            Console.WriteLine(sw2.Elapsed);



            Console.WriteLine((sw2.Elapsed - sw.Elapsed).TotalMilliseconds);


        }


        //[Fact]
        //public void FizzBuzzAlg_Fizz_ModNinityNineIsFizz()
        //{
        //    Assert.Equal("Fizz", f.Get(99));
        //}

        //[Fact]
        //public void FizzBuzzAlg_Fizz_ModOneIsNotFizz()
        //{
        //    Assert.Equal("1", f.Get(1));
        //}

        //[Fact]
        //public void FizzBuzzAlg_Buzz_ModFiveIsBuzz()
        //{
        //    Assert.Equal("Buzz", f.Get(5));
        //}

        //[Fact]
        //public void FizzBuzzAlg_Buzz_SeventyEightModFiveIsBuzz()
        //{
        //    Assert.Equal("78", f.Get(78));
        //}

        //[Fact]
        //public void FizzBuzzAlg_Buzz_ModFiveIsBuzz()
        //{
        //    Assert.Equal("Buzz", f.Get(5));
        //}

        //[Fact]
        //public void FizzBuzzAlg_Buzz_SeventyEightModFiveIsBuzz()
        //{
        //    Assert.Equal("78", f.Get(78));
        //}


    }
}