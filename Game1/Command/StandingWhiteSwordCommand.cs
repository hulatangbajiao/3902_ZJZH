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

        private ILink Link;

        public StandingWhiteSwordCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {

            

            Link.UseItem();
        }

        public void Stop()
        {
            Link.Stop();

        }
    }
   
}
