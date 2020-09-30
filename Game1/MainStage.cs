using Game1.Controller;
using Microsoft.Xna.Framework;
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


        /// <summary>
        /// Active sprite. Exposed as a class property
        /// </summary>

        //Link class
        public ILink Link { get; set; }
        /// <summary>
        /// A list that holds all loaded sprites.
        /// 
        /// </summary>

        public MainStage()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = GlobalDefinitions.GraphicsWidth;
            graphics.PreferredBackBufferHeight = GlobalDefinitions.GraphicsHeight;

            

            controllers = new List<IController>
            {
                new MouseController(this),
                new KeyboardController(this)
            };
            Link = new Link(this);
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

            // Create instances and register commands
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        

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

            Link.Update();
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

            Link.State.GetSprite.Draw(spriteBatch, Link.Position);

            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
