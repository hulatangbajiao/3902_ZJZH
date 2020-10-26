using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class BoundaryShort : IBlock
    {
        public Vector2 Position { get; set; }



        public bool exist { get; set; }


        public BoundaryShort(Vector2 Position)
        {


            this.Position = Position;

            exist = true;


        }
        public void Update()
        {
        }
        public void Draw(SpriteBatch spritebatch)
        {

        }

        public Rectangle GetRectangle()
        {
            return new Rectangle((int)Position.X, (int)Position.Y, (int)(GlobalDefinitions.Boundary / GlobalDefinitions.RoomWidth * GlobalDefinitions.GraphicsWidth), GlobalDefinitions.GraphicsHeight);
        }
    }
}
