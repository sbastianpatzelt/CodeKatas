﻿using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Objects;

namespace FizzBuzzKata
{
    public class FizzBuzzerAkoNhu: IFizzBuzzer
    {
        public string Get(int i)
        {
            if (IsFizzBuzz(i))
                return "FizzBuzz";
            if (IsBuzz(i))
                return "Buzz";
            if (IsFizz(i))
                return "Fizz";

            return i.ToString();
        }

        public IEnumerable<string> Get(IEnumerable<int> i)
        {
            return i.Select(Get);
        }

        private bool IsFizzBuzz(int i)
        {
            return i%15 == 0;
        }

        private bool IsFizz(int i)
        {
            return i % 3 == 0;
        }

        private bool IsBuzz(int i)
        {
            return i % 5 == 0;
        }
    }
}