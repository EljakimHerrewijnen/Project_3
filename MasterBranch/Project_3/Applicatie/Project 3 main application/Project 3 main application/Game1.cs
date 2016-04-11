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
        Dictionary<string, SpriteFont> fontDict = new Dictionary<string, SpriteFont>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            Marcel_basis Marcel_Basis = new Marcel_basis();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            Marcel_Basis.Initialize(textureDict);
            Marco_Basis.Initialize();
            Marc_Basis.Initialize();
            Paul_Basis.Initialize();
            Eljakim_Basis.Initialize();

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

            Marcel_Basis.LoadContent(textureDict, this, fontDict);
            Marco_Basis.LoadContent(textureDict, this);
            Marc_Basis.LoadContent(textureDict, this);
            Paul_Basis.LoadContent(textureDict, this);
            Eljakim_Basis.LoadContent(textureDict, this);

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

            Marcel_Basis.unloadContent();
            Marco_Basis.unloadContent();
            Marc_Basis.unloadContent();
            Paul_Basis.unloadContent();
            Eljakim_Basis.unloadContent();


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


            Marcel_Basis.Update(gameTime);
            Marco_Basis.Update(gameTime);
            Marc_Basis.Update(gameTime);
            Paul_Basis.Update(gameTime);
            Eljakim_Basis.Update(gameTime);

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

            Marcel_Basis.Draw(spriteBatch, textureDict, fontDict);
            Marco_Basis.Draw(spriteBatch, textureDict);
            Marc_Basis.Draw(spriteBatch, textureDict);
            Paul_Basis.Draw(spriteBatch, textureDict);
            Eljakim_Basis.Draw(spriteBatch, textureDict);


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
