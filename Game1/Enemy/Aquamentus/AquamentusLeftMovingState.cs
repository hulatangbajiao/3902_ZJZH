using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    internal class AquamentusLeftMovingState : IEnemyState
    {
        private Aquamentus Aquamentus;
        public IEnemyFactory factory { get; set; }
        public IGeneralSprite GetSprite { get; set; }
        public bool die { get; set; }
        private int deathtimer = 30;

        public AquamentusLeftMovingState(Aquamentus Aquamentus, IEnemyFactory factory)

        {
            die = false;
            this.Aquamentus = Aquamentus;
            this.factory = factory;
            GetSprite = new GeneralSprite(150, 204, 4);

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
            if (!die)
            {
                Aquamentus.Position = Aquamentus.Position + new Vector2(-1, 0) * Aquamentus.MovingSpeed;
            }
            else {
                deathtimer--;
            }
            if (deathtimer == 0) {
                Aquamentus.exist = false;
            }
            
        }
        public void BreatheFire()
        {
            if (!die)
            {
                factory.AddEnemy(new EnemyFireBall(Aquamentus.Position, new Vector2(-1, 1), factory));
                factory.AddEnemy(new EnemyFireBall(Aquamentus.Position, new Vector2(-1, -1), factory));
                factory.AddEnemy(new EnemyFireBall(Aquamentus.Position, new Vector2(-1, 0), factory));
            }
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 Position)
        {
            if (!die)
            {
                this.GetSprite.Draw(Texture2DStorage.GetLeftAquamentusSpriteSheet(), spriteBatch, Position);
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