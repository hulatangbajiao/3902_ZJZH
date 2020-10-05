using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NextBlockCommand : ICommand
    {

        private IBlockList list;

        public NextBlockCommand(IBlockList BlockList)
        {
            list = BlockList;
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
