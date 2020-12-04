using Game1.Block;
using Game1.Controller;
using Game1.Interfaces;
using Game1.Level;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Game1;
using Game1.Inventory;
using Game1.GameState;

namespace Game1
{
    public class MainStage : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private List<IController> controllers;
        private SpriteFont font;

        public InventoryMenu InventoryMenu { get; set; }
        public IGameState GameOver { get; set; }
        public IGameState GameWin { get; set; }
        public IController gameOverKeybroad { get; set; }
        public IController gameWinKeybroad { get; set; }
        public IController MenuKeyBroadController { get; set; }
        public IController MenuGamepadController { get; set; }
        


        public DungeonLevel dungeonlevel { get; set; }
        private static IGeneralSprite headSprite = new GeneralSprite(1536, 336, 1);
        private static IGeneralSprite EmptyBloodHeartSprite = new GeneralSprite(48, 48, 1);
        private static IGeneralSprite HalfBloodHeartSprite = new GeneralSprite(48, 48, 1);
        private static IGeneralSprite FullBloodHeartSprite = new GeneralSprite(48, 48, 1);

        /// <summary>
        /// Active sprite. Exposed as a class property
        /// </summary>

        //Link class
        public ILink Link { get; set; }
        /// <summary>
        /// A list that holds all loaded sprites.
        /// 
        /// </summary>
        //Projectile Factory
        public IProjectileFactory ProjectileFactory { get; set; }
        public IEnemyFactory enemyFactory { get; set; }
        public IItemFactory itemFactory { get; set; }
        public IBlockFactory blockFactory { get; set; }
        public ILinkState[] Linkstates { get; }
        public bool paused { get; set; }

        public MainStage()
        {

            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalDefinitions.GraphicsWidth;
            graphics.PreferredBackBufferHeight = GlobalDefinitions.GraphicsHeightIncludeHead;

            this.Link = new Link(this);
            this.ProjectileFactory = new ProjectileFactory(this);
            this.blockFactory = new BlockFactory(this);
            this.enemyFactory = new EnemyFactory(this);
            this.itemFactory = new ItemFactory(this);
            this.dungeonlevel = new DungeonLevel(this);
            this.InventoryMenu = new InventoryMenu(this);

            controllers = new List<IController>
            {
                new KeyboardController(this), new MouseController(this), new GamepadController(this)
            };
            gameOverKeybroad = new KeybroadGameOver(this);
            gameWinKeybroad = new KeybroadGameWin(this);
            MenuKeyBroadController = new MenuKeyBroadController(this);
            MenuGamepadController = new MenuGamepadController(this);

        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // Explicitly set mouse visible option to make the game intuitive
            this.dungeonlevel.initialize();
            this.IsMouseVisible = true;
            this.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 100.0f);
            this.IsFixedTimeStep = false;
            graphics.SynchronizeWithVerticalRetrace = false;
            this.ProjectileFactory.Initialize();
            this.blockFactory.Initialize();
            this.enemyFactory.Initialize();
            this.itemFactory.Initialize();

            // Create instances and register commands
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            AudioFactory.Instance.LoadAllAudio(this.Content);
            AudioFactory.Instance.PlayDungeonBGM();
            Texture2DStorage.LoadAllTextures(this.Content);

            font = Content.Load<SpriteFont>("Score");
            this.GameOver = new GameOver();
            this.GameWin = new GameWin();
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            if (!paused && Link.Life > 0 && Link.TriforceNumber == 0)
            {
                foreach (var controller in controllers)
                {
                    controller.Update();
                }
                this.ProjectileFactory.Update();
                Link.Update();
                base.Update(gameTime);
                this.dungeonlevel.Update(gameTime);
            }
            else
            {
                this.MenuKeyBroadController.Update();
            }
            if (Link.Life == 0)
            {
                this.gameOverKeybroad.Update();
            }
            if (Link.TriforceNumber > 0)
            {
                this.gameWinKeybroad.Update();
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            this.dungeonlevel.Draw(spriteBatch);
            Link.State.Draw(spriteBatch);
            this.ProjectileFactory.Draw(spriteBatch);
            headSprite.Draw(Texture2DStorage.HeadExteriorSpriteSheet, spriteBatch, new Vector2(0, 1056));

            

            if (Link.HeartContainer < 8)
            {
                for (int i = 0; i < Link.HeartContainer; i++)
                {
                    EmptyBloodHeartSprite.Draw(Texture2DStorage.GetHeartNoBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                }
            }
            else
            {
                for (int k = 0; k < 8; k++)
                {
                    EmptyBloodHeartSprite.Draw(Texture2DStorage.GetHeartNoBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * k, 1248));

                }
                for (int j = 0; j < Link.HeartContainer - 8; j++)
                {
                    EmptyBloodHeartSprite.Draw(Texture2DStorage.GetHeartNoBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * j, 1296));

                }

            }
            if (Link.Life < 16)
            {

                if (Link.Life % 2 == 0)
                {
                    for (int i = 0; i < Link.Life / 2; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                    }

                }
                else
                {
                    for (int i = 0; i < Link.Life / 2; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                    }

                    HalfBloodHeartSprite.Draw(Texture2DStorage.GetHeartHalfBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * (Link.Life / 2), 1248));
                }
            }
            else
            {
                if (Link.Life % 2 == 0)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));
                    }
                    for (int j = 0; j < Link.Life / 2 - 8; j++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * j, 1296));

                    }



                }
                else
                {
                    for (int i = 0; i < Link.Life / 2; i++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * i, 1248));

                    }
                    for (int j = 0; j < Link.Life / 2 - 8; j++)
                    {
                        FullBloodHeartSprite.Draw(Texture2DStorage.GetHeartFullBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * j, 1296));

                    }


                    HalfBloodHeartSprite.Draw(Texture2DStorage.GetHeartHalfBloodSpriteSheet(), spriteBatch, new Vector2(1056 + 48 * ((Link.Life - 16) / 2), 1296));
                }



            }
            

            
                spriteBatch.DrawString(font, Link.RupeeNumber.ToString(), new Vector2(720, 1210), Color.White, 0, font.MeasureString(Link.RupeeNumber.ToString()), 3.0f, SpriteEffects.None, 1f);
               spriteBatch.DrawString(font, Link.KeyNumber.ToString(), new Vector2(720, 1310), Color.White, 0, font.MeasureString(Link.KeyNumber.ToString()), 3.0f, SpriteEffects.None, 1f);
              spriteBatch.DrawString(font, Link.BombNumber.ToString(), new Vector2(720, 1360), Color.White, 0, font.MeasureString(Link.BombNumber.ToString()), 3.0f, SpriteEffects.None, 1f);
            if (paused)
            {
                this.InventoryMenu.Draw(spriteBatch, new Vector2(0, 0));

            }
            if (Link.Life <= 0)
            {
                AudioFactory.Instance.StopDungeonBG();
                this.GameOver.Draw(spriteBatch);
            }
            if (Link.TriforceNumber > 0)
            {
                AudioFactory.Instance.StopDungeonBG();
                this.GameWin.Draw(spriteBatch);
            }
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void Restart()
        {
            this.Link.State = new UpIdleState(this.Link, this);
            GlobalDefinitions.Position = new Vector2(GlobalDefinitions.GraphicsWidth / 2, GlobalDefinitions.GraphicsHeight / 2);
            this.ProjectileFactory = new ProjectileFactory(this);
            this.dungeonlevel = new DungeonLevel(this);
            Initialize();
            this.Link.Life = 6;
            this.Link.HeartContainer = 3;
            this.Link.HasBoomer = false;
            this.Link.HasBow = false;
            this.Link.HasCompass = false;
            this.Link.HasMap = false;
            this.Link.TriforceNumber = 0;
            
        }
        public void continueGame()
        {
            this.dungeonlevel = new DungeonLevel(this);
            this.dungeonlevel.initialize();
            this.Link.Life = 6;
            this.Link.HeartContainer = 3;
        }

    }
}