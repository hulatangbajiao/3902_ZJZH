using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class StandingMagicalRodCommand : ICommand
    {
<<<<<<< HEAD

=======
<<<<<<< Updated upstream
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e
        private IPlayer player;

        public StandingMagicalRodCommand(IPlayer Link)
        {
            player = Link;
=======
        private ILink Link;

        public StandingMagicalRodCommand(ILink Link)
        {
            this.Link = Link;
>>>>>>> Stashed changes
        }

        private ILink Link;

        public StandingMagicalRodCommand(ILink Link)
        {
            this.Link = Link;

        }

        public void Execute()
        {
<<<<<<< HEAD

            //Link.UseMagicalRod();

=======
<<<<<<< Updated upstream
            Link.UseMagicalRod();
=======
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e
            Link.UseItem();
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
