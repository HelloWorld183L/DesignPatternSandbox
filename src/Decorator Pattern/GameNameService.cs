using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeThirdPartyLib
{
    public class GameNameService
    {
        private IGameLookupProvider _lookupProvider;

        public GameNameService(IGameLookupProvider lookupProvider)
        {
            _lookupProvider = lookupProvider;
        }

        public IEnumerable<string> GetGameList()
        {
            return _lookupProvider.GetVideoGameList(); 
        }
    }
}
