namespace Game1
{
    internal class DamagedLinkState : ILinkState
    {
        private Link decoratedLink;
        private MainStage game;
        public ISprite GetSprite { get; set; }
        public DamagedLinkState(Link decoratedLink, MainStage game)
        {
            this.decoratedLink = decoratedLink;
            this.game = game;
            GetSprite = new DamagedLinkSprite(decoratedLink.Position);
        }

        public void TakeDamage()
        {
            
        }
        public void MoveUp()
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
       
        public void Stop()
        {

        }

        public void Attack()
        {

        }

        public void Update()
        {

        }
        public void UseItem()
        {
        }
    }
}