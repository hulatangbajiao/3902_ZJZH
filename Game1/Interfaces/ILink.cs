using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface ILink
    {
        ILinkState State { get; set; }
        int Item { get; set; }
        
        void TakeDamage();
        void MoveLeft();
        void MoveUp();

        void MoveDown();
        void MoveRight();
        void Stop();
        void Attack();
        void Update();
        void UseItem(int Item);
        Rectangle GetRectangle();
    }
}
