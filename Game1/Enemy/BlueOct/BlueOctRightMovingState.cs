using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueOctRightMovingState : IEnemyState
    {
        private BlueOct BlueOct;
        public IEnemyFactory factory { get; set; }
        public ISprite GetSprite { get; set; }

        public BlueOctRightMovingState(BlueOct blueoct, IEnemyFactory factory)
        {
            this.BlueOct = blueoct;
            this.factory = factory;
            GetSprite = new RightMovingBlueOctSprite();
        }

        public void MoveUp()
        {
            BlueOct.State = new BlueOctUpMovingState(BlueOct, factory);

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
        }

        public void Update()
        {
            GetSprite.Update();
            BlueOct.Position = BlueOct.Position + new Vector2(1, 0) * BlueOct.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueOct.Position, new Vector2(1, 0), factory));
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