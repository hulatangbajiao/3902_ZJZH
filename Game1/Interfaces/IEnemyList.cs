using Game1.Enemy_NPC;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Interfaces
{
    public interface IEnemyList
    {
        List<IEnemy> enemyList { get; set; }
        void MoveToPrev();
        void MoveToNext();
        void Update(Game game);
        void Draw(SpriteBatch spriteBatch);
    }
}
