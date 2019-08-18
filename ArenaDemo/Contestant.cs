using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaScenario
{
    public class Contestant : IContestant
    {
        private List<ISpectator> _spectators;

        public Contestant()
        {
            _spectators = new List<ISpectator>();
        }

        public void AddSpectator(ISpectator spectator)
        {
            if (!_spectators.Contains(spectator))
            {
                _spectators.Add(spectator);
            }
        }

        public void RemoveSpectator(ISpectator spectator)
        {
            for (int i = _spectators.Count; i >= 0; i--)
            {
                _spectators.Remove(spectator);
            }
        }

        public void Notify()
        {
            foreach (var spectator in _spectators)
            {
                spectator.UpdateInfo();
            }
        }
    }
}
