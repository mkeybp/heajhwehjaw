using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace heajhwehjaw
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public List<GameObject> gameObjects = new List<GameObject>();

        Pathfinder pathfinder;

        public Student student;

        Vector2 cPath;

        Map map = new Map();
        public Texture2D studentTex;
        private Texture2D playerStudent;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// </summary>
        protected override void Initialize()
        {
         
                base.Initialize();
        }

        /// <summary>
        /// LoadContent is the place to load all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            pathfinder = new Pathfinder(map);
            List<Vector2> path = pathfinder.FindPath(new Point(0, 0), new Point(9, 9));
            foreach (Vector2 point in path)
            {
                System.Diagnostics.Debug.WriteLine(point);
                gameObjects.Add(student = new Student(playerStudent, point));
            }

            List<Texture2D> textures = new List<Texture2D>()
            {
                Content.Load<Texture2D>("GrassTile"),
                Content.Load<Texture2D>("RoadTile"),
               
            };
            playerStudent = Content.Load<Texture2D>("GrassTile");
            map.SetTextures(textures);
        }

        /// <summary>
        /// UnloadContent is the place to unload all content.
        /// </summary>
        protected override void UnloadContent()
        {

        }

        /// <summary>
        /// Allows the game to run logic such as updating the world.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
                 
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin(SpriteSortMode.FrontToBack);

            map.Draw(spriteBatch);


            //spriteBatch.Draw(student, point.X, null, Color.White, 0, Vector2.Zero, 1.0f, SpriteEffects.None, 1f);

            //foreach (GameObject gameObject in gameObjects)
            //{
            //    gameObject.Update(gameTime);
            //}
       
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
