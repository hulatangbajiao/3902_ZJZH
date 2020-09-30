namespace Game1
{
    internal class DamagedLinkState : ILinkState
    {
        private DamagedLink damagedLink;
        private MainStage game;
        public DamagedLinkSprite GetSprite;
        public DamagedLinkState(DamagedLink damagedLink, MainStage game)
        {
            this.damagedLink = damagedLink;
            this.game = game;
            GetSprite = new DamagedLinkSprite(damagedLink.position);
        }

        public void TakeDamage()
        {
            
        }
        public void MoveUp()
        {
        }
        //if 'w'key is being pressed for a long time(more than once in one Update cycle), link will be animated and move up in y axis.
        public void KeepMoveUp()
        {

        }

        public void MoveDown()
        {

        }

        public void KeepMoveDown()
        {
        }
        public void MoveLeft()
        {
        }
        public void KeepMoveLeft()
        {
        }

        public void MoveRight()
        {
        }
        public void KeepMoveRight()
        {
        }
        public void UseWoodenSword()
        {
        }

        public void UseWhiteSword()
        {
        }

        public void UseMagicalRod()
        {
        }

        public void UseItem()
        {
        }
    }
}