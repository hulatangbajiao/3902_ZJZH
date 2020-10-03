using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingWoodenSwordCommand : ICommand
    {
<<<<<<< HEAD

=======
<<<<<<< Updated upstream
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e
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
        private ILink Link;

        public StandingWoodenSwordCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {
<<<<<<< HEAD

=======
<<<<<<< Updated upstream
            Link.UseWoodenSword();
=======
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e
            Link.Attack();
        }

        public void Stop()
        {
            Link.Stop();
<<<<<<< HEAD

=======
>>>>>>> Stashed changes
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e
        }
    }
   
}
