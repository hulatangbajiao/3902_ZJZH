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
        private int timer = 0;
        private bool damaging = false;
        private Vector2 damageDirection = new Vector2(0, 0);
        public ILinkState State { get; set; }
        public int Item { get; set; }
        public Link(MainStage game)
        {
            Item = 0;
            State = new UpIdleState(this, game);
            GlobalDefinitions.Position = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
        }

        public void TakeDamage(Vector2 DamageDirection)
        {
            damageDirection = DamageDirection;
            damaging = true;
            timer = 20;

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
            return new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 96, 96);
        }
    }
}
