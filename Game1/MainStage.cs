using Game1.Controller;
using Game1.Sprite;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game1
{
    /// <summary>
    /// Yan Zhang
    /// </summary>
    public class MainStage : Game
    {
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private List<IController> controllers;

<<<<<<< Updated upstream
        private ISprite staticTextSprite;
=======
       

>>>>>>> Stashed changes

        /// <summary>
        /// Active sprite. Exposed as a class property
        /// </summary>
        public ISprite ActiveSprite { get; set; }

        /// <summary>
        /// A list that holds all loaded sprites.
        /// 
        /// </summary>
        public ISprite[] LoadedSprites { get; }

        public ILinkState[] Linkstates { get; }

        public MainStage()
        {
            graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalDefinitions.GraphicsWidth;
            graphics.PreferredBackBufferHeight = GlobalDefinitions.GraphicsHeight;
<<<<<<< Updated upstream
=======
            this.Link = new Link(this);
>>>>>>> Stashed changes

            this.Link = new Link(this);


            staticTextSprite = new TextSprite(this);

            LoadedSprites = new ISprite[(int) GlobalDefinitions.SpriteModes.Invalid];
            LoadedSprites[(int)GlobalDefinitions.SpriteModes.StaticFixed] = new StaticFixedSprite(this);
            LoadedSprites[(int)GlobalDefinitions.SpriteModes.StaticVerticalMoving] = new StaticVerticalMovingSprite(this);
            LoadedSprites[(int)GlobalDefinitions.SpriteModes.AnimatedFixed] = new AnimatedFixedSprite(this);
            LoadedSprites[(int)GlobalDefinitions.SpriteModes.AnimatedHorizontalMoving] = new AnimatedHorizontalMovingSprite(this);

           



            controllers = new List<IController>
            {
                new KeyboardController(this)
            };
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
            this.IsMouseVisible = true;
            this.TargetElapsedTime = TimeSpan.FromSeconds(1.0f / 100.0f);
            this.IsFixedTimeStep = false;
            graphics.SynchronizeWithVerticalRetrace = false;


            // Create instances and register commands
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
<<<<<<< Updated upstream

            staticTextSprite.LoadResources();
            for (int i = 1; i < (int) GlobalDefinitions.SpriteModes.Invalid; i++)
            {
                LoadedSprites[i].LoadResources();
            }

            // Set default sprite
            ActiveSprite = LoadedSprites[(int) GlobalDefinitions.SpriteModes.StaticFixed];
=======
            
            Texture2DStorage.LoadAllTextures(this.Content);

>>>>>>> Stashed changes
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
            foreach (var controller in controllers)
            {
                controller.Update();
            }

            ActiveSprite?.Update();
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

<<<<<<< Updated upstream
            ActiveSprite?.Draw(spriteBatch);
            staticTextSprite.Draw(spriteBatch);
=======
            Link.State.GetSprite.Draw(spriteBatch);
>>>>>>> Stashed changes

            spriteBatch.End();
            base.Draw(gameTime);
        }

        
    }
}
