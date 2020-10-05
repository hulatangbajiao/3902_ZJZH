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
        private ILink Link;

        public StandingWoodenSwordCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {

            Link.Attack();
        }

        public void Stop()
        {
            Link.Stop();

        }
    }
   
}
