using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingMagicalRodCommand : ICommand
    {

        private IPlayer player;

        public StandingMagicalRodCommand(IPlayer Link)
        {
            player = Link;
        }

        private ILink Link;

        public StandingMagicalRodCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {

            //Link.UseMagicalRod();

            Link.UseItem();
        }

        public void Stop()
        {
            Link.Stop();

        }
    }
}
