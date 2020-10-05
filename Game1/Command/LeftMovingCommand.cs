using Game1.Command;

namespace Game1.Controller
{
    internal class LeftMovingCommand : ICommand
    {
        private IPlayer link;

        public LeftMovingCommand(IPlayer link)
        {
            this.link = link;
        }
    }
}
=======
﻿using System;
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
