
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class RedGoriyaLeftMovingState : IEnemyState
    {
        private RedGoriya RedGoriya;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }

        public RedGoriyaLeftMovingState(RedGoriya redgoriya, IEnemyFactory factory)

        {
            this.RedGoriya = redgoriya;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
            RedGoriya.State = new RedGoriyaUpMovingState(RedGoriya, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            RedGoriya.State = new RedGoriyaDownMovingState(RedGoriya, factory);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            RedGoriya.State = new RedGoriyaRightMovingState(RedGoriya, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            RedGoriya.Position = RedGoriya.Position + new Vector2(-1, 0) * RedGoriya.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(RedGoriya.Position, new Vector2(-1, 0), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(Texture2DStorage.GetLeftMovingRedGoriyaSpriteSheet(),spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}