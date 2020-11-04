using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NPCPreviousCommand : ICommand
    {
        private ISprite[] items;
        private ISprite item1;
        private ISprite item2;
        private ISprite item3;
        private ISprite current;

        public NPCPreviousCommand(ISprite item1, ISprite item2, ISprite item3, ISprite current)
        {
            this.current = current;
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

