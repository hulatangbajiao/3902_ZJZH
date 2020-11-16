using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class OctDownMovingState : IEnemyState
    {
        private Oct Oct;
        public IEnemyFactory factory { get; set; }
        public ISprite GetSprite { get; set; }

        public OctDownMovingState(Oct oct, IEnemyFactory factory)
        {
            this.Oct = oct;
            this.factory = factory;
            GetSprite = new DownMovingOctSprite();

        }

        public void MoveUp()
        {
            Oct.State = new OctUpMovingState(Oct, factory);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
        }


        public void MoveLeft()
        {
            Oct.State = new OctLeftMovingState(Oct, factory);

        }


        public void MoveRight()
        {
            Oct.State = new OctRightMovingState(Oct, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            Oct.Position = Oct.Position + new Vector2(0, 1) * Oct.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(Oct.Position, new Vector2(0, 1), factory));
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