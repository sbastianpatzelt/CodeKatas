using System.Collections.Generic;

namespace FizzBuzz.Objects
{
    public interface IFizzBuzzer
    {
        string Get(int i);
        IEnumerable<string> Get(IEnumerable<int> i);
    }
}
