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
            
        }
        public void Stop()
        {
        }
    }
}