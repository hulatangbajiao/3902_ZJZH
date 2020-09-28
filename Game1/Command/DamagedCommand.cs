using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class DamagedCommand : ICommand
    {
        private IPlayer player;

        public DamagedCommand(IPlayer Link)
        {
            player = Link;
        }

        public void Execute()
        {
            Link.damaged();
        }
    }
    
}
