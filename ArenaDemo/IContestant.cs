using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public interface IContestant
    {
        void AddSpectator(ISpectator spectator);
        void RemoveSpectator(ISpectator spectator);
        void Notify();
    }
}
