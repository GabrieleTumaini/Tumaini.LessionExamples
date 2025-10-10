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

        public int Health { get; private set; }

        public bool isAlive { get; private set; }

        public string Name
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
        }

        // Constructor
        public Enemy() { }
        public Enemy(string name)
        {
            SetName(name);
        }

        public Enemy(string name, int health)
        {
            SetName(name);
            SetHealth(health);

        }

         //function
         public void SetName(string newname)
         {
            if (!string.IsNullOrWhiteSpace(newname))
                _name = newname;
         }

        public void SetHealth(int newhealth)
        {
            if (int.IsPositive(newhealth) && newhealth <= 100)
            {
                _health = newhealth;
            }
        }

        public string getname()
        { 
            return _name; 
        }
        public int gethealth()
        {
            return _health;
        }

        public void TakeDamage(int damage)
        {
            if (int.IsPositive(damage))
            {
                Health -= damage;
                if (Health <= 0)
                {
                    Health = 0;
                    isAlive = false;
                }
            }
        }

    }


}
