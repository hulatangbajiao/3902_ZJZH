
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueGoriyaUpMovingState : IEnemyState
    {
        private BlueGoriya BlueGoriya;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public BlueGoriyaUpMovingState(BlueGoriya Bluegoriya, IEnemyFactory factory)

        {
            die = false;
            this.BlueGoriya = Bluegoriya;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);

        }

        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {
            BlueGoriya.State = new BlueGoriyaDownMovingState(BlueGoriya, factory);

        }


        public void MoveLeft()
        {
            BlueGoriya.State = new BlueGoriyaLeftMovingState(BlueGoriya, factory);
        }


        public void MoveRight()
        {
            BlueGoriya.State = new BlueGoriyaRightMovingState(BlueGoriya, factory);
        }

        public void Update()
        {
            GetSprite.Update();
            
            if (!die)
            {
                BlueGoriya.Position = BlueGoriya.Position + new Vector2(0, -1) * BlueGoriya.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                BlueGoriya.exist = false;
            }
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueGoriya.Position, new Vector2(0, -1), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetUpMovingBlueGoriyaSpriteSheet(), spriteBatch, Position);
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