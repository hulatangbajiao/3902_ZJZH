using Game1.Block;
using Game1.Controller;
using Game1.Interfaces;
using Game1.Level;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Game1;

namespace Game1.Head
{
    class HeadDisplay
    {

        private SpriteBatch spriteBatch;
        private SpriteFont font;
        private static IGeneralSprite headSprite = new GeneralSprite(1536, 336, 1);
        private static IGeneralSprite EmptyBloodHeartSprite = new GeneralSprite(48, 48, 1);
        private static IGeneralSprite HalfBloodHeartSprite = new GeneralSprite(48, 48, 1);
        private static IGeneralSprite FullBloodHeartSprite = new GeneralSprite(48, 48, 1);

        public void Update()
        {


        }

        public void Draw()
        {
            
          
            headSprite.Draw(Texture2DStorage.HeadExteriorSpriteSheet, spriteBatch, new Vector2(0, 1056));
            int HeartContainer = 12;
            int life = 19;
            if (HeartContainer < 8)
            {
                for (int i = 0; i < HeartContainer; i++)
                {
                    EmptyBloodHeartSprite.Draw(Texture2DStorage.GetHeartNoBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                }
            }
            else
            {
                for (int k = 0; k < 8; k++)
                {
                    EmptyBloodHeartSprite.Draw(Texture2DStorage.GetHeartNoBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * k, 1248));

                }
                for (int j = 0; j < HeartContainer - 8; j++)
                {
                    EmptyBloodHeartSprite.Draw(Texture2DStorage.GetHeartNoBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * j, 1296));

                }

            }
            if (life < 16)
            {

                if (life % 2 == 0)
                {
                    for (int i = 0; i < life / 2; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                    }

                }
                else
                {
                    for (int i = 0; i < life / 2; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                    }

                    HalfBloodHeartSprite.Draw(Texture2DStorage.GetHeartHalfBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * (life / 2), 1248));
                }
            }
            else
            {
                if (life % 2 == 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));
                    }
                    for (int j = 0; j < life / 2 - 8; j++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * j, 1296));

                    }



                }
                else
                {
                    for (int i = 0; i < life / 2; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                    }
                    for (int j = 0; j < life / 2 - 8; j++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * j, 1296));

                    }


                    HalfBloodHeartSprite.Draw(Texture2DStorage.GetHeartHalfBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * ((life - 16) / 2), 1296));
                }



            }
            int bombscore = 111;
            int keyscore = 222;
            int rupeescore = 333;


            spriteBatch.DrawString(font, bombscore.ToString(), new Vector2(720, 1360), Color.White, 0, font.MeasureString(bombscore.ToString()), 3.0f, SpriteEffects.None, 1f);
            spriteBatch.DrawString(font, keyscore.ToString(), new Vector2(720, 1310), Color.White, 0, font.MeasureString(keyscore.ToString()), 3.0f, SpriteEffects.None, 1f);
            spriteBatch.DrawString(font, rupeescore.ToString(), new Vector2(720, 1210), Color.White, 0, font.MeasureString(rupeescore.ToString()), 3.0f, SpriteEffects.None, 1f);

            //     spriteBatch.DrawString(font, Link.RupeeNumber.ToString(), new Vector2(720, 1210), Color.White, 0, font.MeasureString(Link.RupeeNumber.ToString()), 3.0f, SpriteEffects.None, 1f);
            //   spriteBatch.DrawString(font, Link.KeyNumber.ToString(), new Vector2(720, 1310), Color.White, 0, font.MeasureString(Link.KeyNumber.ToString()), 3.0f, SpriteEffects.None, 1f);
            //  spriteBatch.DrawString(font, Link.BombNumber.ToString(), new Vector2(720, 1360), Color.White, 0, font.MeasureString(Link.BombNumber.ToString()), 3.0f, SpriteEffects.None, 1f);
          
        }





    }
}
