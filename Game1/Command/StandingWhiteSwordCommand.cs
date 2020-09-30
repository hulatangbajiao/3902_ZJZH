using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingWhiteSwordCommand : ICommand
    {
        private IPlayer player;

        public StandingWhiteSwordCommand(IPlayer Link)
        {
            player = Link;
        }

        public void Execute()
        {
            Link.UseWhiteSword();
        }
    }
   
}
