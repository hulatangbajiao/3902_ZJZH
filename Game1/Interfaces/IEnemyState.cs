namespace Game1
{
    public interface IEnemyState
    {
        ISprite GetSprite { get; set; }

        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
        void Update();
        void BreatheFire();
    }
}