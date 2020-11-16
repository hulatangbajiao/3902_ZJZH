using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Game1.Sprite_.Enemy_Sprite.BlueGoriyaMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueGoriyaLeftMovingState : IEnemyState
    {
        private BlueGoriya BlueGoriya;
        public IEnemyFactory factory { get; set; }
        private ISprite GetSprite { get; set; }

        public BlueGoriyaLeftMovingState(BlueGoriya Bluegoriya, IEnemyFactory factory)

        {
            this.BlueGoriya = Bluegoriya;
            this.factory = factory;
            GetSprite = new LeftMovingBlueGoriyaSprite();

        }

        public void MoveUp()
        {
            BlueGoriya.State = new BlueGoriyaUpMovingState(BlueGoriya, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueGoriya.State = new BlueGoriyaDownMovingState(BlueGoriya, factory);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            BlueGoriya.State = new BlueGoriyaRightMovingState(BlueGoriya, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            BlueGoriya.Position = BlueGoriya.Position - new Vector2(1, 0) * BlueGoriya.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueGoriya.Position, new Vector2(-1, 0), factory));
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