
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NextItemCommand : ICommand
    {

        private IItemList list;

        public NextItemCommand(IItemList ItemList)
        {
            list = ItemList;
        }




        public void Execute()
        {

            list.MoveToNext();
        }

        public void Stop()
        {


        }
    }

}
