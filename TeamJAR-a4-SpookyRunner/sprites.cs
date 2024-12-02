using Game10003;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TeamJAR_a4_SpookyRunner
{
    internal class sprites
    {
        string dir = System.IO.Directory.GetCurrentDirectory();
        Vector2 characterPos = new Vector2(0, 280);
        Vector2 enemyPos = new Vector2(630, 330);
        Vector2 gravity = new Vector2(0, 10);
        Vector2 speed = new Vector2(0, 0);
        Vector2 enemySpeed = new Vector2(-50, 0);
        Vector2 enemyGravity = new Vector2(0, 0);
        Texture2D moon;
        Texture2D guy;
        Texture2D bat;
        public void Setup()
        {
            Window.TargetFPS = 60;
            Window.SetSize(800, 600);
            moon = Graphics.LoadTexture("../../../Sprites/Moon.png");
            guy = Graphics.LoadTexture("../../../Sprites/Guy2.png");
            bat = Graphics.LoadTexture("../../../Sprites/Bat2.png");
        }

    public void Update()
        {
            Graphics.Draw(moon, 500, 0);

            Graphics.Draw(guy, characterPos);

            Graphics.Draw(bat, enemyPos);

            speed += gravity * Time.DeltaTime;
            characterPos += speed * 7 * Time.DeltaTime;

            enemySpeed += enemyGravity * Time.DeltaTime;
            enemyPos += enemySpeed * Time.DeltaTime;

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
                speed.Y -= 25;
            }
        }
    }

}
