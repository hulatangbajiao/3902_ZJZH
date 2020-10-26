using Game1.Interfaces;

namespace Game1
{
    public interface IRoom
    {
        ILink Link { get; set; }
        System.Collections.Generic.List<IEnemy> Enemies { get; set; }
        System.Collections.Generic.List<IItem> ReceivedItems { get; set; }
        System.Collections.Generic.List<IItem> ObtainedItems { get; set; }
        System.Collections.Generic.List<IProjectile> Projectiles { get; set; }
        System.Collections.Generic.List<IBlock> Block { get; set; }
        System.Collections.Generic.List<IBlock> Wall { get; set; }
        System.Collections.Generic.List<IBlock> Boundary { get; set; }

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

        void Initialize(ILink link, System.Collections.Generic.List<IEnemy> enemies, System.Collections.Generic.List<IItem> ReceivedItems, System.Collections.Generic.List<IItem> ObtainedItems, System.Collections.Generic.List<IBlock> blocks);
        void Update();
        void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch);
    }
}
