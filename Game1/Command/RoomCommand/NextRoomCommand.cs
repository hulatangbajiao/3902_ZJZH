using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NextRoomCommand : ICommand
    {
        private List<IRoom> RoomList;
        public NextRoomCommand(List<IRoom> RoomList)
        {
            this.RoomList = RoomList;
        }
        public void Execute()
        {
            RoomList.MoveToNext();
        }
    }
}
