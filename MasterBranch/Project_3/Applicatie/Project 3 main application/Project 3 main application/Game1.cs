using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

/*
eigenaar van deze file: "Marcel Bostelaar"
*/


namespace Project_3_main_application
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Dictionary<string, Texture2D> textureDict = new Dictionary<string, Texture2D>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            Marcel_basis.Initialize();
            Marco_basis.Initialize();
            Marc_basis.Initialize();
            Paul_basis.Initialize();
            Eljakim_basis.Initialize();

            //Algemene initialisatie
            this.IsMouseVisible = true;



            /*
            *TODO: Add your initialization logic here
            */

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // Create a new SpriteBatch, which can be used to draw textures.

            Marcel_basis.LoadContent(textureDict, this);
            Marco_basis.LoadContent(textureDict, this);
            Marc_basis.LoadContent(textureDict, this);
            Paul_basis.LoadContent(textureDict, this);
            Eljakim_basis.LoadContent(textureDict, this);

            /*
            *TODO: use this.Content to load your game content here
            */
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {

            Marcel_basis.unloadContent();
            Marco_basis.unloadContent();
            Marc_basis.unloadContent();
            Paul_basis.unloadContent();
            Eljakim_basis.unloadContent();


            /* TODO: Unload any non ContentManager content here
            *
            *
            *
            */
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();


            Marcel_basis.Update(gameTime);
            Marco_basis.Update(gameTime);
            Marc_basis.Update(gameTime);
            Paul_basis.Update(gameTime);
            Eljakim_basis.Update(gameTime);

            /* TODO: Add your update logic here
            *
            *
            *
            *
            */

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

            Marcel_basis.Draw(spriteBatch, textureDict);
            Marco_basis.Draw(spriteBatch, textureDict);
            Marc_basis.Draw(spriteBatch, textureDict);
            Paul_basis.Draw(spriteBatch, textureDict);
            Eljakim_basis.Draw(spriteBatch, textureDict);

            spriteBatch.End();


            /* TODO: Add your drawing code here
            *
            *
            *
            *
            */

            base.Draw(gameTime);
        }
    }
}
