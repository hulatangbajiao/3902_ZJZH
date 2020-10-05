using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class BlockPreviousCommand : ICommand
    {
        private IPlayer[] items;
        private IPlayer item1;
        private IPlayer item2;
        private IPlayer item3;

        public BlockPreviousCommand(IPlayer item1, IPlayer item2, IPlayer item3)
        {
            items[0] = item1;
            items[1] = item2;
            items[2] = item3;
        }

        public void Execute()
        {

        }
        public void Stop()
        {

        }
    }
}

