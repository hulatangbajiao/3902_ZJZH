using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class PauseGameCommand : ICommand
    {
        private MainStage game;

        public PauseGameCommand(MainStage game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.paused)
                game.paused = false;
            else
            {
                game.paused = true;
            }
        }
    }
}
