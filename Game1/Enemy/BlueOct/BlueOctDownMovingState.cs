
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueOctDownMovingState : IEnemyState
    {
        private BlueOct BlueOct;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public BlueOctDownMovingState(BlueOct blueoct, IEnemyFactory factory)
        {
            die = false;
            this.BlueOct = blueoct;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);
        }

        public void MoveUp()
        {
            BlueOct.State = new BlueOctUpMovingState(BlueOct, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
            BlueOct.State = new BlueOctLeftMovingState(BlueOct, factory);
        }


        public void MoveRight()
        {
            BlueOct.State = new BlueOctRightMovingState(BlueOct, factory);
        }

        public void Update()
        {
            GetSprite.Update();
            
            if (!die)
            {
                BlueOct.Position = BlueOct.Position + new Vector2(0, 1) * BlueOct.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                BlueOct.exist = false;
            }
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueOct.Position, new Vector2(0, 1), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetDownMovingBlueOctorokSpriteSheet(), spriteBatch, Position);
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