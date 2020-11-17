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
    public class Boomer : IProjectile
    {
        

        private IGeneralSprite GetSprite { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Direction { get; set; }
        public int Velocity { get; set; }

        public bool exist { get; set; }

        
        public Boomer(Vector2 Position, Vector2 direction)
        {
            

            this.Position = Position + new Vector2(30,30);
            Direction = direction;
            Velocity = 30;
            exist = true;
            
            GetSprite = new GeneralSprite(48,48,3);
            
            

        }
        public void Hit()
        {
            Velocity = -Velocity;
        }
        public void Update()
        {

            Velocity--;
            if (Velocity >= 0)
            {
                Position = Position + Direction * Velocity;
            }
            else 
            {
                double angle = Math.Atan2(Position.Y - (GlobalDefinitions.Position + new Vector2(30, 30)).Y , (GlobalDefinitions.Position + new Vector2(30, 30)).X - Position.X);
                
                Position -= new Vector2((float)(Math.Cos(angle) * Velocity), (float)(Math.Sin(2*Math.PI-angle) * Velocity));
            }
            
            GetSprite.Update();

            if ((Velocity<0) && (Position.X > GlobalDefinitions.Position.X) && (Position.Y > GlobalDefinitions.Position.Y)&&(Position.Y < GlobalDefinitions.Position.Y + 60)&&(Position.X < GlobalDefinitions.Position.X + 60)) 
            {
                exist = false;
            }
        }

        

        public void Draw(SpriteBatch spriteBatch)
        {
            if (exist)
            {
                GetSprite.Draw(Texture2DStorage.GetBoomerSpriteSheet(),spriteBatch, Position);
            }
        }

        public Rectangle GetRectangle()
        {
            return this.GetSprite.GetRectangle();
        }
    }
}
