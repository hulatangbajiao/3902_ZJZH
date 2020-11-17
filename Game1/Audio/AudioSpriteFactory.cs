using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1
{
    public class AudioFactory
    {
        private List<SoundEffect> soundEffect = new List<SoundEffect>();
        private SoundEffect dungeonBGM;
        private SoundEffect titleBGM;
        private SoundEffectInstance SEInstanceDungeonBGM;
        private SoundEffectInstance SEInstanceTitleBGM;

        private static AudioFactory instance = new AudioFactory();

        public static AudioFactory Instance
        {
            get
            {
                return instance;
            }
        }

        private AudioFactory()
        {
        }

        public void LoadAllAudio(ContentManager content)
        {
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Attack Hit Sound"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Discovery Jingle"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Dying"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Item Jingle"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Pick Up Bow"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Pick Up Item"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Pick Up Rupee"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Secret Jingle"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Text Drawing"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Triforce Pickup"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Unlock Door"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Wallmaster Sound"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Bomb"));
            soundEffect.Add(content.Load<SoundEffect>("Audio\\Bow"));

            titleBGM = content.Load<SoundEffect>("Audio\\Title BGM");
            dungeonBGM = content.Load<SoundEffect>("Audio\\Underworld BGM");
            SEInstanceDungeonBGM = dungeonBGM.CreateInstance();
            SEInstanceTitleBGM = titleBGM.CreateInstance();
        }

        public void PlayAttackSound()
        {
            soundEffect[0].Play();
        }
        public void PlayDiscoverySound()
        {
            soundEffect[1].Play();
        }
        public void PlayDyingSound()
        {
            soundEffect[2].Play();
        }
        public void PlayItemSound()
        {
            soundEffect[3].Play();
        }
        public void PlayPickUpBowSound()
        {
            soundEffect[4].Play();
        }
        public void PlayPickUpItemSound()
        {
            soundEffect[5].Play();
        }
        public void PlayPickUpRupeeSound()
        {
            soundEffect[6].Play();
        }
        public void PlaySecretSound()
        {
            soundEffect[7].Play();
        }
        public void PlayTextSound()
        {
            soundEffect[8].Play();
        }
        public void PlayTriforcePickupSound()
        {
            soundEffect[9].Play();
        }
        public void PlayUnlockDoorSound()
        {
            soundEffect[10].Play();
        }
        public void PlayWallmasterSound()
        {
            soundEffect[11].Play();
        }
        public void PlayBombSound()
        {
            soundEffect[12].Play();
        }
        public void PlayBowSound()
        {
            soundEffect[13].Play();
        }

        public void PlayTitleBGM()
        {
            
            SEInstanceTitleBGM.IsLooped = true;
            SEInstanceTitleBGM.Volume = 0.5f;
            SEInstanceTitleBGM.Play();
        }
        public void PlayDungeonBGM()
        {
            
            SEInstanceDungeonBGM.IsLooped = true;
            SEInstanceDungeonBGM.Volume = 0.5f;
            SEInstanceDungeonBGM.Play();
        }
        public void StopPlay()
        {
            
            SEInstanceTitleBGM.Stop();
            SEInstanceDungeonBGM.Stop();
        }
    }
}
