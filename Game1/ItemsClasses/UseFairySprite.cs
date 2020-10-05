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
using System.Security.Cryptography.X509Certificates;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Runtime.InteropServices;
using System.Xml.Schema;


namespace TextureAtlas
{
    class UseFairySprite : Iitem
    {
        public Texture2D Texture { get; set; }
        public int Rows { get; set; }
        public int Columns { get; set; }
        private int currentFrame;
        private int totalFrames;

        private int x = 450;
        private int y = 150;

        public UseFairySprite(Texture2D FairySpriteSheet)
        {
            Texture = FairySpriteSheet;
            Rows = 1;
            Columns = 2;
            currentFrame = 0;
            totalFrames = Rows * Columns;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame == totalFrames)
            {
                currentFrame = 0;
            }

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


        }

        public void Draw(SpriteBatch spriteBatch)
        {

            int width = Texture.Width / Columns;
            int height = Texture.Height / Rows;
            int row = (int)((float)currentFrame / (float)Columns);
            int column = currentFrame % Columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle(x, y, width / 8, height / 8);

            spriteBatch.Begin();
            spriteBatch.Draw(Texture, destinationRectangle, sourceRectangle, Color.White);
            spriteBatch.End();

        }
    }
}