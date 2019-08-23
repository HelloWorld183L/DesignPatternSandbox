using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SomeThirdPartyLib
{
    public class SomeSlowExpensiveThing : IGameLookupProvider
    {
        public IEnumerable<string> GetVideoGameList()
        {
            Console.WriteLine("Using the old slow way....");

            Thread.Sleep(3000);

            return new List<string> { "Pacman", "Dig dug", "Prince of Persia" };
        }
    }
}
