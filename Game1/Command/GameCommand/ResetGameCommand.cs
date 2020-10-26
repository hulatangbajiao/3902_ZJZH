using Microsoft.Xna.Framework;
using System;

namespace Game1.Command
{
    class ResetGameCommand : ICommand
    {
        private MainStage game;

        public ResetGameCommand(MainStage game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Restart();
        }
    }
}