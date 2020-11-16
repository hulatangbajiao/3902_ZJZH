﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Game1.Sprite_;
using Game1.Interfaces;
using Game1;

namespace Game1.ItemsClasses
{
    class UseTriforceSprite : ISprite
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;
        private int x = 450;
        private int y = 150;
        private int maxTime;
        private Rectangle destinationRectangle;
        public UseTriforceSprite()
        {

            Rows = 1;
            Columns = 2;
            currentFrame = 0;
            totalFrames = Rows * Columns;
        }

        public void Update()
        {
            maxTime++;
            if (maxTime > 10)
            {
                currentFrame++;
                maxTime = 0;
            }
            if (currentFrame == totalFrames)
                currentFrame = 0;


        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            Texture = Texture2DStorage.GetTriforceSpriteSheet();
            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            destinationRectangle = new Rectangle((int)Position.X, (int)Position.Y, width / 2, height / 2);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();
        }

        public Rectangle GetRectangle()
        {
            return destinationRectangle;
        }


    }
}