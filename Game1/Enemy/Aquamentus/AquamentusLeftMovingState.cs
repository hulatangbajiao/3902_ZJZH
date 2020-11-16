using Game1.Sprite_.Enemy_Sprite.AquamentusMoving;
using Game1.Sprite_.Enemy_Sprite.OctMoving;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class AquamentusLeftMovingState : IEnemyState
    {
        private Aquamentus Aquamentus;
        public IEnemyFactory factory { get; set; }
        private ISprite GetSprite { get; set; }
        

        public AquamentusLeftMovingState(Aquamentus Aquamentus, IEnemyFactory factory)

        {
            this.Aquamentus = Aquamentus;
            this.factory = factory;
            GetSprite = new LeftMovingAquamentusSprite();

        }

        public void MoveUp()
        {

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            Aquamentus.State = new AquamentusRightMovingState(Aquamentus, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            Aquamentus.Position = Aquamentus.Position + new Vector2(-1,0) * Aquamentus.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(Aquamentus.Position, new Vector2(0, -1), factory));
            factory.AddEnemy(new EnemyFireBall(Aquamentus.Position, new Vector2(1, -1), factory));
            factory.AddEnemy(new EnemyFireBall(Aquamentus.Position, new Vector2(-1, -1), factory));

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