using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Link : ILink
    {
        public int BombNumber { get; set; }
        public int RupeeNumber { get; set; }
        public int KeyNumber { get; set; }
        public int TriforceNumber { get; set; }
        public bool HasBow { get; set; }
        public bool HasCompass { get; set; }
        public bool HasBoomer { get; set; }
        public bool HasMap { get; set; }
        public int Life { get; set; }
        public int HeartContainer { get; set; }
        public int timer { get; set; }
        public bool damaging { get; set; }
        private Vector2 damageDirection = new Vector2(0, 0);
        public ILinkState State { get; set; }
        public int Item { get; set; }
        public Link(MainStage game)
        {
            Life = 6;
            HeartContainer = 3; 
            BombNumber = 0;
            RupeeNumber = 0;
            KeyNumber = 0;
            TriforceNumber = 0;
            HasBow = false;
            HasCompass = false;
            HasBoomer = false;
            HasMap = false;
            Item = 0;
            damaging = false;
            timer = 0;
            State = new UpIdleState(this, game);
            GlobalDefinitions.Position = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
        }

        public void TakeDamage(Vector2 DamageDirection)
        {
            damageDirection = DamageDirection;
            damaging = true;
            timer = 20;
             Life--;
            //remains to be discussed
        }

        public void MoveUp()
        {
            State.MoveUp();
        }


        public void MoveDown()
        {
            State.MoveDown();
        }

        public void MoveLeft()
        {
            State.MoveLeft();
        }

        public void MoveRight()
        {
            State.MoveRight();
        }

        public void Stop()
        {
            State.Stop();
        }

        public void Attack()
        {
            State.Attack();
        }

        public void UseItem(int Item)
        {
            this.Item = Item;
            State.UseItem();

        }

        public void Update()
        {
            if (timer > 0)
            {
                timer--;
                State.GetSprite.ChangeColor();
            }
            else
            {
               State.GetSprite.color = Color.White;
            }
            if (timer < 16)
            {
                damaging = false;
            }
            if (!damaging)
            {
                State.Update();
            }
            else
            {
                GlobalDefinitions.Position -= 30 * damageDirection;
            }
        }

        public Rectangle GetRectangle() 
        {
            return new Rectangle((int)GlobalDefinitions.Position.X+12, (int)GlobalDefinitions.Position.Y+12, 72, 72);
        }
    }
}
