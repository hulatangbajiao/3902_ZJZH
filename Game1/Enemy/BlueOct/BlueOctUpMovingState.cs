using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueOctUpMovingState : IEnemyState
    {
        private BlueOct BlueOct;
        public IEnemyFactory factory { get; set; }
        public ISprite GetSprite { get; set; }

        public BlueOctUpMovingState(BlueOct blueoct, IEnemyFactory factory)
        {
            this.BlueOct = blueoct;
            this.factory = factory;
            GetSprite = new UpMovingBlueOctSprite();
        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueOct.State = new BlueOctDownMovingState(BlueOct, factory);

        }


        public void MoveLeft()
        {
            BlueOct.State = new BlueOctLeftMovingState(BlueOct, factory);
        }


        public void MoveRight()
        {
            BlueOct.State = new BlueOctRightMovingState(BlueOct, factory);
        }

        public void Update()
        {
            GetSprite.Update();
            BlueOct.Position = BlueOct.Position + new Vector2(0, -1) * BlueOct.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueOct.Position, new Vector2(0, -1), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}