using System.Collections.Generic;

namespace ExchangeRateUpdater.Interfaces
{
    public interface ICnbParser
    {
        Dictionary<string, decimal> Parse(string txtContent);
    }
}