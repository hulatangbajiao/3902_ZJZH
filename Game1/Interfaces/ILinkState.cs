using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public interface ILinkState
    {

        IGeneralSprite GetSprite { get; set; }
        
        void MoveLeft();
        void MoveUp();

        void MoveDown();
        void MoveRight();
        void Stop();
        void Attack();

        void Update();
        void UseItem();
        void Draw(SpriteBatch spriteBatch);
    }
}