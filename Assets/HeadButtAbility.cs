public class HeadButtAbility : Ability
{
    public int damage;
    public override void Play(Battler battler)
    {
        battler.opponent.TakeDamage(damage);
    }
}