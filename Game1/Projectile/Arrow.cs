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
    public class Arrow : IProjectile
    {
        public IProjectileSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int Velocity { get; set; }

        public bool exist { get; set; }

        
        public Arrow(Vector2 Position, Vector2 direction)
        {
            

            this.Position = Position + new Vector2(30,30);
            Direction = direction;
            Velocity = 40;
            exist = true;
            if (Direction.X == (float)1)
            {
                GetSprite = new RightArrowSprite();
            }
            else if (Direction.X == (float)-1)
            {
                GetSprite = new LeftArrowSprite();
            }
            else if (Direction.Y == (float)1)
            {
                GetSprite = new DownArrowSprite();
            }
            else if (Direction.Y == (float)-1)
            {
                GetSprite = new UpArrowSprite();
            }

        }

        public void Update()
        {
            

            Position = Position + Direction * Velocity;
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
                GetSprite.Draw(spriteBatch, Position);
            }
        }

        
    }
}
