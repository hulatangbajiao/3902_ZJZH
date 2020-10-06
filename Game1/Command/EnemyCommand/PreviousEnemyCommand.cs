using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class PreviousEnemyCommand : ICommand
    {

        private EnemyList list;

        public PreviousEnemyCommand(EnemyList EnemyList)
        {
            list = EnemyList;
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
