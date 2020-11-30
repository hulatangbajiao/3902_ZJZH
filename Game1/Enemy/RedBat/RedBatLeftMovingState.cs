
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class RedBatLeftMovingState : IEnemyState
    {
        private RedBat RedBat;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public RedBatLeftMovingState(RedBat redBat, IEnemyFactory factory)

        {
            die = false;
            this.RedBat = redBat;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
            RedBat.State = new RedBatUpMovingState(RedBat, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            RedBat.State = new RedBatDownMovingState(RedBat, factory);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            RedBat.State = new RedBatRightMovingState(RedBat, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            
            if (!die)
            {
                RedBat.Position = RedBat.Position + new Vector2(-1, 0) * RedBat.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                RedBat.exist = false;
            }
        }
        public void BreatheFire()
        {
            
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetUpMovingRedBatSpriteSheet(), spriteBatch, Position);
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