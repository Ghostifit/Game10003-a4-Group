using Game10003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamJAR_a4_SpookyRunner.Game10003
{
    public class CustomSound
    {
        Music myMusic;
        Sound JumpSound;
        Sound ZombieSound;
        Sound BatSound;


        public void setup()
        {
            //Audio for background music
            myMusic = Audio.LoadMusic("../../../SoundAssets/BackgroundMusic.mp3");

            //Audio for jump sound effect
            JumpSound = Audio.LoadSound("../../../SoundAssets/Jump.mp3");
            //Audio for Zombie sound effect
            ZombieSound = Audio.LoadSound("../../../SoundAssets/Zombie.mp3");
            //Audio for Bat sound effect
            BatSound = Audio.LoadSound("../../../SoundAssets/Bat.mp3");
        }

        void Update()
        {

        }
    }
}