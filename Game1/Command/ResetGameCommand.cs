using Microsoft.Xna.Framework;
using System;

namespace Game1.Command
{
    class ResetGameCommand : ICommand
    {
        private Game gameInstance;

        public ResetGameCommand(Game instance)
        {
            gameInstance = instance ?? throw new ArgumentNullException(nameof(instance));
        }

        public void Execute()
        {
<<<<<<< Updated upstream
            
=======
<<<<<<< HEAD

        }
        public void Stop()
        {

=======
<<<<<<< Updated upstream
=======
            
        }
        public void Stop()
        {
>>>>>>> Stashed changes
>>>>>>> 7138942d4ffb4ce348a80ca24494c5f810f3311e
>>>>>>> Stashed changes
        }
    }
}