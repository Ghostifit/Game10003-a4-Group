﻿// Include code libraries you need below (use the namespace).
using System;
using System.IO;
using System.Numerics;
using System.Text.RegularExpressions;
using TeamJAR_a4_SpookyRunner;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        collision collision = new collision();
        sprites sprites = new sprites();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {    
            Window.SetSize(800, 600);
            Window.SetTitle("Spooky Runner");
            sprites.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {   Window.ClearBackground(Color.Gray);
            collision.Update();
            sprites.Update();
        }
    }
}
 