using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/*  Deze file is van: "Paul de Keijzer"
*
*/

namespace Project_3_main_application
{
    class Paul_basis
    {
        internal static void LoadContent(Dictionary<string, Texture2D> textDict, Game1 game1)
        {
            //Hier kan je al je plaatjes enzo laden
            textDict.Add("test2", game1.Content.Load<Texture2D>("pacman.png"));
        }

        internal static void Initialize()
        {
            //Hier kan je initializatie doen
        }

        internal static void unloadContent()
        {
            //Hier kan je dingen ontladen
        }

        internal static void Update(GameTime gameTime)
        {
            //Hier moet je update logica komen
        }

        internal static void Draw(SpriteBatch spriteBatch, Dictionary<string, Texture2D> textDict)
        {
            spriteBatch.Draw(textDict["test2"], new Vector2(100, 0), Color.White);
            //Hier moet je drawen
        }
    }
}
