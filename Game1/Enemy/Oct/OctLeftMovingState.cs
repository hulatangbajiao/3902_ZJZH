
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class OctLeftMovingState : IEnemyState
    {
        private Oct Oct;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }

        public OctLeftMovingState(Oct oct, IEnemyFactory factory)
        {
            this.Oct = oct;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
            Oct.State = new OctUpMovingState(Oct, factory);
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            Oct.State = new OctDownMovingState(Oct, factory);

        }


        public void MoveLeft()
        {

        }


        public void MoveRight()
        {
            Oct.State = new OctRightMovingState(Oct, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            Oct.Position = Oct.Position + new Vector2(-1, 0) * Oct.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(Oct.Position, new Vector2(-1, 0), factory));
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(Texture2DStorage.GetLeftMovingOctorokSpriteSheet(),spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}