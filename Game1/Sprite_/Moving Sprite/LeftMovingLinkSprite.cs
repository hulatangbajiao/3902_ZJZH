﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Sprite_
{
    public class LeftMovingLinkSprite : ISprite
    {
        private int currentFrame = 0;
        private int totalFrame = 2;

        public LeftMovingLinkSprite()
        {


        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrame)
                currentFrame = 0;

            GlobalDefinitions.Position.X = GlobalDefinitions.Position.X - (float)1; //change the y axis position of Link
            if (GlobalDefinitions.Position.X == 0)
            {
                GlobalDefinitions.Position.X = (float)GlobalDefinitions.GraphicsWidth;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle;
            Rectangle destinationRectangle;

            if (currentFrame == 0)
            {
                sourceRectangle = new Rectangle(0, 0, 209, 230);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 90, 100);//I don't understand why the width of destinationRectangle has to be like this.
            }


            else
            {
                sourceRectangle = new Rectangle(573, 0, 770, 230);
                destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 400, 100);
            }

            spriteBatch.Draw(Texture2DStorage.GetLeftMovingLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);//use Texture2DStorage class to load texture2D
        }
    }
}