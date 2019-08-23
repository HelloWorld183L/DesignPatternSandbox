using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeThirdPartyLib;

namespace SomeThirdPartyLib
{
    public class FastCachedGameThing : IGameLookupProvider
    {
        private IGameLookupProvider _innerGameLookupProvider;
        private IEnumerable<string> _cachedList;

        public FastCachedGameThing(IGameLookupProvider innerGameLookupProvider)
        {
            _innerGameLookupProvider = innerGameLookupProvider;
        }

        public IEnumerable<string> GetVideoGameList()
        {
            Console.WriteLine("New way in progress!");

            if (_cachedList == null)
            {
                _cachedList = _innerGameLookupProvider.GetVideoGameList();
            }
            return _cachedList;
        }
    }
}
