using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Enemy_NPC
{
    public class MerchantG : IEnemy
    {
        public IEnemyState State { get; set; }
        public MerchantG()
        {
            State = new MerchantGState();
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
