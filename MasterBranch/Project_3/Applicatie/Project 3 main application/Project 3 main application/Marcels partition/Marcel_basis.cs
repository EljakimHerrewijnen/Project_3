using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

/*  Deze file is van: "Marcel Bostelaar"
*
*/

namespace Project_3_main_application
{
    class Marcel_basis
    {
        internal static SpriteBatch spritebatch(SpriteBatch spriteBatch)
        {
            //Hier kan je al je plaatjes enzo laden
            

            //de return moet blijven
            return spriteBatch;
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

        internal static void Draw(SpriteBatch spriteBatch)
        {
            //Hier moet je drawen
        }
    }
}
