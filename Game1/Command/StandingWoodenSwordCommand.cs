using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingWoodenSwordCommand : ICommand
    {
<<<<<<< Updated upstream
        private IPlayer player;

        public StandingWoodenSwordCommand(IPlayer Link)
        {
            player = Link;
=======
        private ILink Link;

        public StandingWoodenSwordCommand(ILink Link)
        {
            this.Link = Link;
>>>>>>> Stashed changes
        }

        public void Execute()
        {
<<<<<<< Updated upstream
            Link.UseWoodenSword();
=======
            Link.Attack();
        }

        public void Stop()
        {
            Link.Stop();
>>>>>>> Stashed changes
        }
    }
   
}
