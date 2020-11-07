using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Game1.Sprite_.Enemy_Sprite.RedGoriyaMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class RedGoriyaUpMovingState : IEnemyState
    {
        private RedGoriya RedGoriya;
        public IEnemyFactory factory { get; set; }
        public ISprite GetSprite { get; set; }

        public RedGoriyaUpMovingState(RedGoriya redgoriya, IEnemyFactory factory)

        {
            this.RedGoriya = redgoriya;
            this.factory = factory;
            GetSprite = new UpMovingRedGoriyaSprite();

        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            RedGoriya.State = new RedGoriyaDownMovingState(RedGoriya, factory);

        }


        public void MoveLeft()
        {
            RedGoriya.State = new RedGoriyaLeftMovingState(RedGoriya, factory);
        }


        public void MoveRight()
        {
            RedGoriya.State = new RedGoriyaRightMovingState(RedGoriya, factory);
        }

        public void Update()
        {
            GetSprite.Update();
            RedGoriya.Position = RedGoriya.Position + new Vector2(0, -1) * RedGoriya.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(RedGoriya.Position, new Vector2(0, -1), factory));
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