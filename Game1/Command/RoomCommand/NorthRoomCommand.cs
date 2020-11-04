using Game1.Interfaces;
using Game1.Level;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NorthRoomCommand : ICommand
    {
        private DungeonLevel dungeonlevel;
        public NorthRoomCommand(DungeonLevel dungeonlevel)
        {
            this.dungeonlevel = dungeonlevel;
        }
        public void Execute()
        {
            dungeonlevel.North();
        }
    }
}
