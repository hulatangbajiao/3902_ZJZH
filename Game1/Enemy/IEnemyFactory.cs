
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public interface IEnemyFactory
    {
        List<IEnemy> EnemyList { get; set; }
        void Initialize();

        void AddEnemy(IEnemy enemy);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}
