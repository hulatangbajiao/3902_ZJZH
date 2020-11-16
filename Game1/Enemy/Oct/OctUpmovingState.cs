
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class OctUpMovingState : IEnemyState
    {
        private Oct Oct;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }

        public OctUpMovingState(Oct oct, IEnemyFactory factory)
        {
            this.Oct = oct;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            Oct.State = new OctDownMovingState(Oct, factory);

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
            Oct.Position = Oct.Position + new Vector2(0, -1) * Oct.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(Oct.Position, new Vector2(0, -1), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(Texture2DStorage.GetUpMovingOctorokSpriteSheet(),spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}