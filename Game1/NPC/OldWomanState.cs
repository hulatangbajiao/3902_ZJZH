using Game1.Sprite_.NPC_Sprite;

namespace Game1.Enemy_NPC
{
    public class OldWomanState : IEnemyState
    {
        public ISprite GetSprite { get; set; }

        public OldWomanState()
        {
            GetSprite = new OldWomanSprite();
        }
        public void BreatheFire()
        {
        }

        public void MoveDown()
        {
        }

        public void MoveLeft()
        {
        }

        public void MoveRight()
        {
        }

        public void MoveUp()
        {
        }

        public void Update()
        {
        }
    }
}