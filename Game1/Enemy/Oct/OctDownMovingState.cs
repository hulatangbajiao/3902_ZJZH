
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class OctDownMovingState : IEnemyState
    {
        private Oct Oct;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public OctDownMovingState(Oct oct, IEnemyFactory factory)
        {
            die = false;
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
            
            if (!die)
            {
                Oct.Position = Oct.Position + new Vector2(0, 1) * Oct.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                Oct.exist = false;
            }
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyFireBall(Oct.Position, new Vector2(0, 1), factory));
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetDownMovingOctorokSpriteSheet(), spriteBatch, Position);
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