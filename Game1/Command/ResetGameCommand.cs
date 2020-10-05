using Microsoft.Xna.Framework;
using System;

namespace Game1.Command
{
    class ResetGameCommand : ICommand
    {
        private Game gameInstance;

        public ResetGameCommand(Game instance)
        {
            gameInstance = (MainStage)instance ?? throw new ArgumentNullException(nameof(instance));
        }

        public void Execute()
        {
            
            gameInstance.ResetElapsedTime();
        }
        public void Stop()
        {

        }
    }
}