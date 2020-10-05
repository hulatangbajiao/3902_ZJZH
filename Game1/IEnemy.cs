using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Enemy_NPC
{
    public interface IEnemy
    {
        IOctState State { get; set; }

        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void Update();
    }
}
