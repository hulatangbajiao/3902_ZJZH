
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class PreviousItemCommand : ICommand
    {

        private IItemList list;

        public PreviousItemCommand(IItemList ItemList)
        {
            list = ItemList;
        }




        public void Execute()
        {

            list.MoveToPrev();
        }

        public void Stop()
        {


        }
    }

}
