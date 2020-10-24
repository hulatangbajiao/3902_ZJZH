using Game1.Interfaces;
using Game1.ItemsClasses;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class ItemCompass : IItem
    {
        private IItemSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }



        public bool exist { get; set; }


        public ItemCompass(Vector2 Position)
        {


            this.Position = Position;
            
            exist = true;
            
            GetSprite = new UseFairySprite();
            

        }

        public void Update()
        {

            GetSprite.Update();

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(spriteBatch, Position);
            }
        }


    }
}

