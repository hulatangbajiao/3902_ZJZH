using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class PreviousBlockCommand : ICommand
    {

        private IBlockList list;

        public PreviousBlockCommand(IBlockList BlockList)
        {
            list = BlockList;
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
