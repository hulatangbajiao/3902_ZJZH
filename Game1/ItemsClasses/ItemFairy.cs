using Game1.Interfaces;
using Game1.ItemsClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ItemFairy : IItem
    {
        private ISprite GetSprite { get; set; }
        private int x, y;
        public Vector2 Position { get; set; }



        public bool exist { get; set; }


        public ItemFairy(Vector2 Position)
        {


            this.Position = Position;
            
            exist = true;
            
            GetSprite = new UseFairySprite();
            

        }

        public void Update()
        {
            Random rdm = new Random();
            if (x >= 800)
            {
                x = x - rdm.Next(60, 110);
            }
            else if (x <= 0)
            {
                x = x + rdm.Next(60, 110);
            }
            else if (y >= 360)
            {
                y = y - rdm.Next(60, 110);
            }
            else if (y <= 0)
            {
                y = y + rdm.Next(60, 110);
            }
            else
            {
                x = x + rdm.Next(-15, 15);
                y = y + rdm.Next(-10, 10);
            }

            Position = Position + new Vector2(x,y);

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(spriteBatch, Position);
            }
        }

        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}

