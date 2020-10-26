using Game1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class PreviousRoomCommand : ICommand
    {
        private List<IRoom> RoomList;
        public PreviousRoomCommand(List<IRoom> RoomList)
        {
            this.RoomList = RoomList;
        }
        public void Execute()
        {
            RoomList.MoveToPrev();
        }
    }
    
}
