using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class SpriteFactoryShell
    {
        // private Texture2D (Name of Texture);

        private static SpriteFactoryShell instance = new SpriteFactoryShell();

        public static SpriteFactoryShell Instance
        {
            get
            {
                return instance;
            }
        }

        private SpriteFactoryShell()
        {
        }

        public void LoadAllTextures(ContentManager content)
        {
            // (Name of Texture) = content.Load<Texture2D>("FileName");
        }

        // public ISprite Create(Block, Item, Enemy, etc.)Sprite()
        // {
        //     return new (Block, Item, Enemy, etc.)Sprite(Name of Texture, X Source Value, Y Source Value, Height, Width);
        // }

        // You will then have a class called (Block, Item, Enemy, etc.)Sprite that will draw the sprite (Example code below)
        /*
         *  namespace Sprint2
         *  {
         *      public class BlockSprite : ISprite
         *      {
         *          private int XSource, YSource, Height, Width;
         *          private Texture2D BlockTexture;
         *          private Rectangle sourceRectangle;
         *          private Vector2 destinationVector;
         *
         *          public BlockSprite(Texture2D texture, int x, int y, int height, int width)
         *          {
         *              BlockTexture = texture;
         *              XSource = x;
         *              YSource = y;
         *              Height = height;
         *              Width = width;
         *          }
         *
         *          public void Update()
         *          {
         *   
         *           }
         *
         *          public void Draw(SpriteBatch spriteBatch, Vector2 location)
         *          {
         *              sourceRectangle = new Rectangle(XSource, YSource, Width, Height);
         *              destinationVector = new Vector2((int)location.X, location.Y);
         *
         *              spriteBatch.Draw(BlockTexture, destinationVector, sourceRectangle, Color.White, 0f, Vector2.Zero, 3f, SpriteEffects.None, 0f);
         *          }
         *      }
         *  }
         */

        // So if you want to create and then draw the associated sprite at a certain location, wherever in your code, you would put the following
        // 
        // private I(Block, Item, Enemy, etc.) (block, item, enemy, etc.);

        // inside the class that will be creating or drawing the image you will use the following
        // (block, item, enemy, etc.) = new (Whatever Block, Item, Enemy, etc. you are creating)(Constructor values);
        // (block, item, enemy, etc.).draw(spriteBatch);
    }
}