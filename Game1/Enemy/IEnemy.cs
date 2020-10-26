using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IEnemy
    {
        IEnemyState State { get; set; }
        Vector2 Position { get; set; }
        Vector2 Direction { get; set; }
        bool exist { get; set; }
        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void Update();
        void Draw(SpriteBatch spritebatch);
        Rectangle GetRectangle();
       
    }
}
