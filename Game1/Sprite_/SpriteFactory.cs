using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class SpriteFactory : ISpriteFaactory
    {
        public List<IGeneralSprite> SpriteList { get; set; }
        public MainStage game;
        public SpriteFactory(MainStage mainstage)
        {
            this.game = mainstage;
            this.SpriteList = new List<IGeneralSprite>();
        }
        public IGeneralSprite AddSprite(Texture2D SpriteSheet, int Width, int Height, int totalPicture)
        {
            IGeneralSprite sprite = new GeneralSprite(Width, Height, totalPicture);
            SpriteList.Add(sprite);
            return sprite;
        }
    }
    
}
