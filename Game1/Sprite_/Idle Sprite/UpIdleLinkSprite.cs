namespace Game1
{
    public class UpIdleLinkSprite
    {
<<<<<<< Updated upstream:Game1/Sprite_/UpIdleLinkSprite.cs
=======

      
        public UpIdleLinkSprite()
        {

        }

        public void Update()
        {
            

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            Rectangle sourceRectangle = new Rectangle(0, 0, 216, 218);
            Rectangle destinationRectangle = new Rectangle((int)GlobalDefinitions.Position.X, (int)GlobalDefinitions.Position.Y, 100, 100);
            //use texture2dStorage to get the texture2d of the sprite
            spriteBatch.Draw(Texture2DStorage.GetUpIdleLinkSpriteSheet(), destinationRectangle, sourceRectangle, Color.White);
        }
>>>>>>> Stashed changes:Game1/Sprite_/Idle Sprite/UpIdleLinkSprite.cs
    }
}