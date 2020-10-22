using Game1.Sprite_.NPC_Sprite;

namespace Game1.Enemy_NPC
{
    public class MerchantPState : IEnemyState
    {
        public ISprite GetSprite { get; set; }

        public MerchantPState()
        {
            GetSprite = new MerchantPSprite();
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