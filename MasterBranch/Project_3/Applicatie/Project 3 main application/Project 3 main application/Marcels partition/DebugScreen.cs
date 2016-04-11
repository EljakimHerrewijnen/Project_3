using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_main_application.Marcels_partition
{
    class DebugScreen
    {
        private Vector2 mouseposition = new Vector2(0, 0);
        private List<string> mousepressed = new List<string>();
        public bool doRender = false;
        private Vector2 drawpos = new Vector2(0, 0);
        private string font = "Testfont";
        private int timesincelasttrigger = 0;


        public DebugScreen()
        {

        }

        public Vector2 Drawpos
        {
            set
            {
                drawpos = value;
            }
        }

        public void Update(GameTime gametime)
        {
            if (Keyboard.GetState().IsKeyDown(Keys.F3))
            {
                if( (int) gametime.TotalGameTime.TotalSeconds - timesincelasttrigger >= 1){
                    timesincelasttrigger = (int)gametime.TotalGameTime.TotalSeconds;
                    doRender = !doRender;
                }
            }
            if (doRender)
            {
                mousepressed.Clear();
                var mousestate = Mouse.GetState();
                mouseposition.X = mousestate.X;
                mouseposition.Y = mousestate.Y;
                if (mousestate.LeftButton == ButtonState.Pressed)
                {
                    mousepressed.Add("LeftButton");
                }
                if (mousestate.MiddleButton == ButtonState.Pressed)
                {
                    mousepressed.Add("MiddleButton");
                }
                if (mousestate.RightButton == ButtonState.Pressed)
                {
                    mousepressed.Add("RightButton");
                }
            }
        }

        public void Draw(Globalvars GlobalVars, SpriteBatch spriteBatch)
        {
            if (doRender)
            {
                string line1 = "Mouse position is: " + mouseposition.X.ToString() + ";" + mouseposition.Y.ToString();
                int line1height = (int)GlobalVars.fontDict[font].MeasureString(line1).Y;
                string line2 = "Buttons pressed: " + string.Join(",", mousepressed.ToArray());
                spriteBatch.DrawString(GlobalVars.fontDict[font], line1, drawpos, Color.White);
                spriteBatch.DrawString(GlobalVars.fontDict[font], line2, drawpos + new Vector2(0, line1height), Color.White);
            }
        }
    }
}
