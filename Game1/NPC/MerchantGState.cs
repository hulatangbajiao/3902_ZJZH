using Game1.Sprite_.NPC_Sprite;

namespace Game1.Enemy_NPC
{
    public class MerchantGState : IEnemyState
    {
        public ISprite GetSprite { get; set; }

        public MerchantGState()
        {
            GetSprite = new MerchantGSprite();
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