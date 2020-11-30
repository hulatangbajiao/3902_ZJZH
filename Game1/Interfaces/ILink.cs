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
        int BombNumber { get; set; }
        int RupeeNumber { get; set; }
        int KeyNumber { get; set; }
        int TriforceNumber { get; set; }
        bool HasBow { get; set; }
        bool HasCompass { get; set; }
        bool HasBoomer { get; set; }
        bool HasMap { get; set; }
        int Life { get; set; }
        int HeartContainer { get; set; }
        ILinkState State { get; set; }
        int Item { get; set; }
        bool damaging { get; set; }
        int timer { get; set; }
        void TakeDamage(Vector2 DamageDirection);
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
