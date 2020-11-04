using Game1.Level;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command.RoomCommand
{
    class WestRoomCommand : ICommand
    {
        private DungeonLevel dungeonlevel;
        public WestRoomCommand(DungeonLevel dungeonlevel)
        {
            this.dungeonlevel = dungeonlevel;
        }
        public void Execute()
        {
            dungeonlevel.West();
        }
    }
}
