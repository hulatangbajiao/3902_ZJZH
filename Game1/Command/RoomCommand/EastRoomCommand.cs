using Game1.Level;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command.RoomCommand
{
    class EastRoomCommand : ICommand
    {
        private DungeonLevel dungeonlevel;
        public EastRoomCommand(DungeonLevel dungeonlevel)
        {
            this.dungeonlevel = dungeonlevel;
        }
        public void Execute()
        {
            dungeonlevel.East();
        }
    }
}
