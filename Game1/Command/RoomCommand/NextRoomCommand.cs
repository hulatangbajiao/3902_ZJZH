using Game1.Interfaces;
using Game1.Level;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NextRoomCommand : ICommand
    {
        private DungeonLevel dungeonLevel;
        public NextRoomCommand(DungeonLevel dungeonLevel)
        {
            this.dungeonLevel = dungeonLevel;
        }
        public void Execute()
        {
            List<IRoom> roomList = dungeonLevel.Rooms;
            IRoom currentRoom = dungeonLevel.CurrentRoom;
            int index = roomList.IndexOf(currentRoom);
            if (index != roomList.Count)
            {
                currentRoom = roomList[index++];
            }
            else
            {
                currentRoom = roomList[0];
            }
        }
    }
}
