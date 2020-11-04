using Game1.Enemy_NPC;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game1.Interfaces
{
    public interface IRoom
    {
        ILink Link { get; set; }
        List<IEnemy> Enemies { get; set; }
        List<Iitem> ReceivedItems { get; set; }
        List<Iitem> ObtainedItems { get; set; }
        List<IProjectile> Projectiles { get; set; }
        List<IBlock> Block { get; set; }
        List<IBlock> Wall { get; set; }
        List<IBlock> Boundary { get; set; }

        IRoom North { get; set; }
        bool HasNorth { get; set; }
        IRoom East { get; set; }
        bool HasEast { get; set; }
        IRoom South { get; set; }
        bool HasSouth { get; set; }
        IRoom West { get; set; }
        bool HasWest { get; set; }
        IRoom Other { get; set; }
        bool HasOther { get; set; }

        void Initialize(ILink link, List<IEnemy> enemies, List<Iitem> ReceivedItems, List<Iitem> ObtainedItems, List<IBlock> blocks);
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }
}