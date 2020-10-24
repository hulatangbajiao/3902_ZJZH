using System.Collections.Generic;

namespace Team4_LegendOfZelda.ILevel_Classes
{
    class DungeonRoom : IRoom
    {
        public ILink Link { get; set; }
        public List<IEnemy> Enemies { get; set; }
        public List<IItem> ReceivedItems { get; set; }
        public List<IItem> ObtainedItems { get; set; }
        public List<IProjectile> Projectiles { get; set; }
        public List<IBlock> Block { get; set; }
        public List<IBlock> Wall { get; set; }
        public List<IBlock> Boundary { get; set; }
        public IRoom North { get; set; }
        public bool HasNorth { get; set; }
        public IRoom East { get; set; }
        public bool HasEast { get; set; }
        public IRoom South { get; set; }
        public bool HasSouth { get; set; }
        public IRoom West { get; set; }
        public bool HasWest { get; set; }
        public IRoom Other { get; set; }
        public bool HasOther { get; set; }


        public DungeonRoom()
        {
            Enemies = new List<IEnemy>();
            ReceivedItems = new List<IItem>();
            ObtainedItems = new List<IItem>();
            Projectiles = new List<IProjectile>();
            Block = new List<IBlock>();
            Boundary = new List<IBlock>();

            HasNorth = false;
            HasEast = false;
            HasSouth = false;
            HasWest = false;
            HasOther = false;
        }

        public void Initialize(IPlayer player, List<IEnemy> enemies, List<IItem> receivedItems, List<IItem> obtainedItems, List<IBlock> blocks)
        {
            Player = player;
            Enemies.AddRange(enemies);
            ReceivedItems.AddRange(receivedItems);
            ObtainedItems.AddRange(obtainedItems);
            Block.AddRange(blocks);
        }

        public void Update()
        {
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Update();
            }


            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Update();
            }

        }

        public void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            foreach (IItem item in ReceivedItems)
            {
                item.Draw(spriteBatch);
            }

            foreach (IItem item in ObtainedItems)
            {
                item.Draw(spriteBatch);
            }
            foreach (IEnemy enemy in Enemies)
            {
                enemy.Draw(spriteBatch);
            }
           
            foreach (IProjectile projectile in Projectiles)
            {
                projectile.Draw(spriteBatch);
            }

          
            foreach (IBlock block in Block)
            {
                if (block.BlockSprite != null)
                {
                    block.Draw(spriteBatch);
                }
            }
        }
    }
}