using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class RightMovingCommand : ICommand
    {
        private IPlayer player;

        public RightMovingCommand(IPlayer Link)
        {
            player = Link;
        }

        public void Execute()
        {
            Link.KeepMoveRight();
            Link.MoveRight();
        }
    }
   
}
