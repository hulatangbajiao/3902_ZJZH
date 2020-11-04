using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Enemy_NPC
{
    public class OldMan : IEnemy
    {
        public IOctState State { get; set; }
        public OldMan()
        {
            State = new OldManState();
        }
        public void MoveDown()
        {
        }

        public void MoveLeft()
        {
        }

        public void MoveRight()
        {
        }

        public void MoveUp()
        {
        }

        public void Update()
        {
        }
        
    }
}
