using Game1.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1.Inventory
{
    public class InventoryMenu : IMenu
    {
        private MainStage game;

        private Vector2 Backgroundposition = new Vector2(0,0);
        private Vector2 MovingPosition;
        private Vector2 SelectionPosition = new Vector2(750,270);
        private Vector2 SelectItemPosition = new Vector2(68*6,48*6);
        
        private Vector2 SmallMapPosition = new Vector2(48*6, 112*6);
        private Vector2 BombPosition = new Vector2(750,270);
        private Vector2 bowPosition = new Vector2(750+96,270);
        private Vector2 CompassPosition = new Vector2(44*6, 152*6);
        private Vector2 BoomerPosition = new Vector2(750+96*2,270);

        private Vector2 SelectionRangeLeftTop = new Vector2(750,270);
        private Vector2 SelectionRangeRightRop = new Vector2(1313 - 96, 270);
        private Vector2 SelectionRangeLeftBottem = new Vector2(750, 497 - 96);
        private Vector2 SelectionRangeRightBottem = new Vector2(1313, 497 - 96);

        private IGeneralSprite Background;
        private IGeneralSprite Selection;
        private IGeneralSprite MapSprite;
        private IGeneralSprite BombSprite;
        private IGeneralSprite BowSprite;
        private IGeneralSprite CompassSprite;
        private IGeneralSprite BoomerSprite;

        private IGeneralSprite selectedItem;

        private const int length = 1539;
        private const int width = 1056;
        private const int square = 96;
        private const int frame = 1;

        public InventoryMenu (MainStage game) {
            this.game = game;
            Background = new GeneralSprite(length, width, frame);
            Selection = new GeneralSprite(square, square, frame);
            MapSprite = new GeneralSprite(square, square, frame);
            BombSprite = new GeneralSprite(square, square, frame);
            BowSprite = new GeneralSprite(square, square, frame);
            CompassSprite = new GeneralSprite(square, square, frame);
            BoomerSprite = new GeneralSprite(square, square, frame);
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 MovingPosition) {
            Background.Draw(Texture2DStorage.GetInventoryBackgroundSpriteSheet(), spriteBatch, Backgroundposition + MovingPosition);
            
            if (MovingPosition == new Vector2(0,0))
            {
                Selection.Draw(Texture2DStorage.GetRedSelectionSpriteSheet(), spriteBatch, SelectionPosition);
                
                if (game.Link.HasMap)
                {
                    MapSprite.Draw(Texture2DStorage.GetMapSpriteSheet(), spriteBatch, SmallMapPosition);
                    //MapPositionSprite.Draw();
                    //LinkPositionSprite.Draw();
                }

                if (game.Link.BombNumber > 0)
                {
                    BombSprite.Draw(Texture2DStorage.GetBombSelectSpriteSheet(), spriteBatch, BombPosition);
                }

                if (game.Link.HasBow)
                {
                    BowSprite.Draw(Texture2DStorage.GetBowSpriteSheet(), spriteBatch, bowPosition);
                }
                if (game.Link.HasCompass)
                {
                    CompassSprite.Draw(Texture2DStorage.GetCompassSpriteSheet(), spriteBatch, CompassPosition);
                }
                if (game.Link.HasBoomer)
                {
                    BoomerSprite.Draw(Texture2DStorage.GetBoomerSelectSpriteSheet(), spriteBatch, BoomerPosition);
                }

                if (selectedItem == BombSprite)
                {
                    BombSprite.Draw(Texture2DStorage.GetBombSpriteSheet(), spriteBatch, SelectItemPosition);
                } else if (selectedItem == BowSprite)
                {
                    BowSprite.Draw(Texture2DStorage.GetBowSpriteSheet(), spriteBatch, SelectItemPosition);

                } else if (selectedItem == BoomerSprite)
                {
                    BoomerSprite.Draw(Texture2DStorage.GetBoomerangSpriteSheet(), spriteBatch, SelectItemPosition);
                }
            }
        }

        public void LinkItem()
        {
            if (SelectionPosition ==  BoomerPosition && game.Link.HasBoomer) 
            {
                selectedItem = BoomerSprite;
            }
            if (SelectionPosition == BombPosition && game.Link.BombNumber > 0)
            {
                selectedItem = BombSprite;
            }
            if (SelectionPosition == bowPosition && game.Link.HasBow)
            {
                selectedItem = BowSprite;
            }
        }

        public void selectDown()
        {
            SelectionPosition.Y = Math.Min(SelectionPosition.Y + square, SelectionRangeLeftBottem.Y);
            LinkItem();
        }

        public void selected()
        {
            
        }

        public void selectLeft()
        {
            SelectionPosition.X = Math.Max(SelectionPosition.X - square, SelectionRangeLeftTop.X);
            LinkItem();
        }

        public void selectRight()
        {
            SelectionPosition.X = Math.Min(SelectionPosition.X + square, SelectionRangeRightRop.X);
            LinkItem();
        }

        public void selectUp()
        {
            SelectionPosition.Y = Math.Max(SelectionPosition.Y - square, SelectionRangeLeftTop.Y);
            LinkItem();
        }
        
    }
}
