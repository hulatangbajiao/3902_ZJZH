using Game1.Interfaces;
using Game1.Level;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class PreviousRoomCommand : ICommand
    {
        private DungeonLevel dungeonLevel;
        public PreviousRoomCommand(DungeonLevel dungeonLevel)
        {
            this.dungeonLevel = dungeonLevel;
        }
        public void Execute()
        {
            List<IRoom> roomList = dungeonLevel.Rooms;
            IRoom currentRoom = dungeonLevel.CurrentRoom;
            int index = roomList.IndexOf(currentRoom);
            if (index != 0)
            {
                currentRoom = roomList[index--];
            } else
            {
                currentRoom = roomList[roomList.Count-1];
            }
        }
    }
    
}
