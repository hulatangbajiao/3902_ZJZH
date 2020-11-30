
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class RedGoriyaDownMovingState : IEnemyState
    {
        private RedGoriya RedGoriya;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public RedGoriyaDownMovingState(RedGoriya redgoriya, IEnemyFactory factory)

        {
            die = false;
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
            
            if (!die)
            {
                RedGoriya.Position = RedGoriya.Position + new Vector2(0, 1) * RedGoriya.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                RedGoriya.exist = false;
            }
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(RedGoriya.Position, new Vector2(0, 1), factory));
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetDownMovingRedGoriyaSpriteSheet(), spriteBatch, Position);
            }
            else
            {
                this.GetSprite.Draw(Texture2DStorage.GetDeathSpriteSheet(), spriteBatch, Position);
            }
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}