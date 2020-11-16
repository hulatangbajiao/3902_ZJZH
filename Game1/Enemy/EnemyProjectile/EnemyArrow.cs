using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class EnemyArrow : IEnemy
    {
        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int MovingSpeed = 40;
        public IEnemyState State { get; set; }
        public bool exist { get; set; }


        public EnemyArrow(Vector2 Position, Vector2 direction, IEnemyFactory factory)
        {
            

            this.Position = Position + new Vector2(30,30);
            Direction = direction;
            
            exist = true;
            if (Direction.X == (float)1)
            {
                GetSprite = new GeneralSprite(20,50,1);
            }
            else if (Direction.X == (float)-1)
            {
                GetSprite = new GeneralSprite(20,50,1);
            }
            else if (Direction.Y == (float)1)
            {
                GetSprite = new GeneralSprite(50,20,1);
            }
            else if (Direction.Y == (float)-1)
            {
                GetSprite = new GeneralSprite(50,20,1);
            }

        }
        public void MoveUp()
        {

        }


        public void MoveDown()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }


        public void Attack()
        {

        }
        public void Update()
        {
            

            Position = Position + Direction * MovingSpeed;
            GetSprite.Update();

            if (Position.X > 2000 || Position.X < -300 || Position.Y < -300 || Position.Y > 2000) 
            {
                exist = false;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                if (Direction.X == (float)1)
                {
                    GetSprite.Draw(Texture2DStorage.GetRightWoodenArrowSpriteSheet(),spriteBatch, Position);
                }
                else if (Direction.X == (float)-1)
                {
                    GetSprite.Draw(Texture2DStorage.GetLeftWoodenArrowSpriteSheet(),spriteBatch, Position);
                }
                else if (Direction.Y == (float)1)
                {
                    GetSprite.Draw(Texture2DStorage.GetDownWoodenArrowSpriteSheet(),spriteBatch, Position);
                }
                else if (Direction.Y == (float)-1)
                {
                    GetSprite.Draw(Texture2DStorage.GetUpWoodenArrowSpriteSheet(),spriteBatch, Position);
                }
                
            }
        }
        
        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }

    }
}
