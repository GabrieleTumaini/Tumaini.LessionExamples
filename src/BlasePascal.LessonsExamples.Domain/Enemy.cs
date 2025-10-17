namespace BlaisePascal.LessonsExamples.Domain
{
    public class Enemy
    {
        //TODO: Attributes decomposition
        // Attributes
        private string _name;
        private string _description;
        private int _health;
        private bool _isAlive;
        private int _attackDamage;
        private int _attackSpeed;
        private int _damageReduction;
        private int _positionX;
        private int _positionY;
        private int _movementSpeed;

        //Properties
        //public int health
        //{
        //    get
        //    {
        //        return _health;
        //    }

        //    private set
        //    {
        //        if (value < 0)
        //        {
        //            throw new argumentoutofrangeexception("value");
        //        }
        //        _health = value;
        //    }
        //}

        public string Name { get; private set; }

        public string Description { get; private set; }
        public int Health { get; private set; }

        public bool IsAlive => Health > 0;

        /*public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int AtakDamage
        {
            get
            {
                return _attackDamage;
            }

            set
            {
                _attackDamage = value;
            }
        }*/

        // Constructor
        public Enemy() { }
        public Enemy(string name)
        {
            Name = name;
        }

        public Enemy(string name, int health = CharachterValidator.MaxHealth)
        {
            Name = CharachterValidator.ValidateName(name);
            Health = CharachterValidator.ValidateHealth(health);
            Description = Description ?? string.Empty;
        }

         //function
         public void SetName(string newname)
         {
            if (!string.IsNullOrWhiteSpace(newname))
                Name = newname;
         }

        public void SetHealth(int newhealth)
        {
            if (int.IsPositive(newhealth) && newhealth <= CharachterValidator.MaxHealth)
            {
                Health = newhealth;
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public void TakeDamage(int damage)
        {
            if (damage < 0)

                throw new ArgumentException();

            Health = Math.Max (Health - damage, CharachterValidator.MinHealth);

        }

        public void Heal(int healAmount)
        {
            if (healAmount < 0 && IsAlive == true)

                throw new ArgumentException();

            Health = Math.Min(Health + healAmount, CharachterValidator.MaxHealth);
        }

    }


}
