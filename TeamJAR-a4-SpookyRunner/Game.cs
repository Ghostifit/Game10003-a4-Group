// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using TeamJAR_a4_SpookyRunner.Game10003;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        CustomSound soundClass;

        collision collision = new collision();
        sprites sprites = new sprites();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(800, 600);
            Window.SetTitle("Spooky Runner");

            soundClass = new CustomSound();
            soundClass.setup();

            sprites.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

        }
    }
}
