using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command.GameCommand
{
    class ContinueGameCommand : ICommand
    {
        private MainStage game;

        public ContinueGameCommand(MainStage game)
        {
            this.game = game;

        }
        public void Execute()
        {
            game.continueGame();
        }
    }
}
