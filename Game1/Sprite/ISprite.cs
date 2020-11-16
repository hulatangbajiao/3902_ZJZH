using Microsoft.Xna.Framework.Graphics;

namespace Game1.Sprite
{
    public interface ISprite
    {
        void LoadResources();
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
