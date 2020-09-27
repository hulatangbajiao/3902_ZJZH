using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class LeftMovingCommand : ICommand
    {
        private IPlayer player;

        public LeftMovingCommand(IPlayer Link)
        {
            player = Link;
        }

        public void Execute()
        {
            Link.KeepMoveLeft();
            Link.MoveLeft();
        }
    }
}
