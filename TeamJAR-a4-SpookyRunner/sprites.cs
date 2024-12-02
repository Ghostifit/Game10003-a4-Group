using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamJAR_a4_SpookyRunner
{
    internal class sprites
    {
        string dir = System.IO.Directory.GetCurrentDirectory();
        Texture2D moon;
        public void Setup()
        {
            Window.TargetFPS = 60;
            Window.SetSize(800, 600);
            moon = Graphics.LoadTexture("../../../Sprites/Moon.png");
        }

    public void Update()
        {
            Graphics.Draw(moon, 500, 0);
        }
    }

}
