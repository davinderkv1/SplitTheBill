// MySplitterLibrary/Splitter.cs
using System;

namespace MySplitterLibrary
{
    public class Splitter
    {
        public decimal SplitAmount(decimal amount, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be greater than 0.");

            return amount / numberOfPeople;
        }
    }
}
