
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueMDownMovingState : IEnemyState
    {
        private BlueM BlueM;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public BlueMDownMovingState(BlueM bluem, IEnemyFactory factory)
        {
            die = false;
            this.BlueM = bluem;
            this.factory = factory;
            GetSprite = new GeneralSprite(96,96,2);
        }

        public void MoveUp()
        {
            BlueM.State = new BlueMUpMovingState(BlueM, factory);

        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), Oct will be animated and move up in y axis.

        public void MoveDown()
        {

        }


        public void MoveLeft()
        {
            BlueM.State = new BlueMLeftMovingState(BlueM, factory);
        }


        public void MoveRight()
        {
            BlueM.State = new BlueMRightMovingState(BlueM, factory);
        }

        public void Update()
        {
            GetSprite.Update();
            
            if (!die)
            {
                BlueM.Position = BlueM.Position + new Vector2(0, 1) * BlueM.MovingSpeed;
            }

            else
            {
                deathtimer--;
            }
            if (deathtimer == 0)
            {
                BlueM.exist = false;
            }
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueM.Position, new Vector2(0, 1), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetDownMovingBlueMSpriteSheet(), spriteBatch, Position);
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