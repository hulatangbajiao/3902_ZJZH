
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class BlueMLeftMovingState : IEnemyState
    {
        private BlueM BlueM;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }

        public BlueMLeftMovingState(BlueM bluem, IEnemyFactory factory)
        {
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
            BlueM.State = new BlueMDownMovingState(BlueM, factory);

        }


        public void MoveLeft()
        {
        }


        public void MoveRight()
        {
            BlueM.State = new BlueMRightMovingState(BlueM, factory);

        }

        public void Update()
        {
            GetSprite.Update();
            BlueM.Position = BlueM.Position + new Vector2(-1, 0) * BlueM.MovingSpeed;
        }
        public void BreatheFire()
        {
            factory.AddEnemy(new EnemyArrow(BlueM.Position, new Vector2(-1, 0), factory));
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            this.GetSprite.Draw(Texture2DStorage.GetLeftMovingBlueMSpriteSheet(),spriteBatch, Position);
        }
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}