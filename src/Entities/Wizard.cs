namespace RPG_Console.src.Entities
{
    public class Wizard : Hero
    {
        public override string Attack()
        {
            return $"{Name} Lancou Magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{Name} Lancou Magia super efetiva com bonus de {bonus}";
            }
            else
            {
                return $"{Name} Lancou Magia com força fraca com bonus de {bonus}";
            }
        }

    }
}
