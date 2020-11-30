using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command.GameCommand
{
    class ResumeGameCommand : ICommand
    {
        private MainStage game;
        public ResumeGameCommand(MainStage game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.paused = false;
        }
    }
}
