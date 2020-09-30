namespace Game1
{
    public interface ILinkState
    {
        ISprite GetSprite { get; set; }
        void TakeDamage();
        void MoveLeft();
        void MoveUp();

        void MoveDown();
        void MoveRight();
        void Stop();
        void Attack();

        void Update();
        void UseItem();
    }
}