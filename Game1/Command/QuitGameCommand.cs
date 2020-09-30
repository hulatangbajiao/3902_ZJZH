using Microsoft.Xna.Framework;
using System;

namespace Game1.Command
{
    class QuitGameCommand : ICommand
    {
        private Game gameInstance;

        public QuitGameCommand(Game instance)
        {
            gameInstance = instance ?? throw new ArgumentNullException(nameof(instance));
        }

        public void Execute()
        {
            gameInstance.Exit();
        }
    }
}