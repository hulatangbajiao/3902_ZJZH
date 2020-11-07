namespace Game1
{
    public interface IMap
    {
        Microsoft.Xna.Framework.Rectangle DestinationRectangle { get; set; }
        ISprite MapSprite { get; set; }

        void North();
        void East();
        void South();
        void West();
        void Other();
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}