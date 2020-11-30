using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public interface IEnemyState
    {
        IGeneralSprite GetSprite { get; set; }
        IEnemyFactory factory { get; set; }
        bool die { get; set; }
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void Update();
        void BreatheFire();
        void Draw(SpriteBatch spriteBatch, Vector2 Position);
        Rectangle GetRectangle();
    }
}