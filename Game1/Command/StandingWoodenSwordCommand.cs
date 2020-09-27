using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingWoodenSwordCommand : ICommand
    {
        private IPlayer player;

        public StandingWoodenSwordCommand(IPlayer Link)
        {
            player = Link;
        }

        public void Execute()
        {
            Link.UseWoodenSword();
        }
    }
   
}
