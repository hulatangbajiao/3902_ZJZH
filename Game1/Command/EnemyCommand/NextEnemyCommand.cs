using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Command
{
    class NextEnemyCommand : ICommand
    {

        private EnemyList list;

        public NextEnemyCommand(EnemyList EnemyList)
        {
            list = EnemyList;
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
