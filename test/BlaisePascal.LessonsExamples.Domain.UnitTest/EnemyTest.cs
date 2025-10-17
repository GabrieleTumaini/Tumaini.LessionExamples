using static System.Net.Mime.MediaTypeNames;

namespace BlaisePascal.LessonsExamples.Domain.UnitTest
{
    public class EnemyTest
    {
        //IMPORTANTE: Il construttore non ha controlli su health e name?




        [Fact]
        public void EnemyName_WhenTheNameIsValid_NameMustBeAssignedCorrectly()
        {
            //Arrange
            Enemy enemy = new Enemy();

            //Act
            enemy.SetName("Stefano");

            //Assert
            Assert.Equal("Stefano", enemy.Name);


        }

        [Fact]
        public void EnemyName_TheNameCannotBeNull()
        {
            //Arrange
            Enemy enemy = new Enemy();


            //Assert
            Assert.Null(enemy.Name);


        }

        [Fact]
        public void EnemyName_TheNameCannotBeEmpty()
        {
            //Arrange
            Enemy enemy = new Enemy();

            //Act
            enemy.SetName("");

            //Assert
            Assert.Null(enemy.Name);


        }

        [Fact]
        public void EnemyName_TheNameCannotBeWhiteSpace()
        {
            //Arrange
            Enemy enemy = new Enemy();
            //Act
            enemy.SetName("   ");
            //Assert
            Assert.Null(enemy.Name);
        }

        [Fact]
        public void SetHealth_WhenTheHealthIsValid_HealthMustBeAssignedCorrectly()
        {
            //Arrange
            Enemy enemy = new Enemy();
            //Act
            enemy.SetHealth(50);
            //Assert
            Assert.Equal(50, enemy.Health);
        }

        [Fact]
        public void SetHealth_TheHealthCannotBeNegative()
        {
            //Arrange
            Enemy enemy = new Enemy();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => enemy.SetHealth(-10));
        }

        [Fact]
        public void SetHealth_TheHealthCannotBeGreaterThan100()
        {
            //Arrange
            Enemy enemy = new Enemy();

            //Act & Assert
            Assert.Throws<ArgumentException>(() => enemy.SetHealth(150));
        }

        [Fact]
        public void SetHealth_WhenHealthIsSetToPositiveValue_IsAliveMustBeTrue()
        {
            //Arrange
            Enemy enemy = new Enemy();
            //Act
            enemy.SetHealth(50);
            //Assert
            Assert.True(enemy.IsAlive);
        }

        [Fact]
        public void TakeDamage_WhenDamageIsValid30_HealthMustDecreaseBy30()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 100);
            int damage = 30;
            //Act
            enemy.TakeDamage(damage);
            //Assert
            Assert.Equal(70, enemy.Health);
        }
        [Fact]
        public void TakeDamage_WhenDamageIsNegative5_ShouldThrowArgumentExeption()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin");
            int damage = -5;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => enemy.TakeDamage(damage));

        }
        [Fact]
        public void TakeDamage_WhenDamage100IsGreaterThanCurrentHealth50_HealthMustBeZeroAndIsAliveMustBeFalse()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 50);
            int damage = 100;

            //Act
            enemy.TakeDamage(damage);

            //Assert
            Assert.Equal(0, enemy.Health);
            Assert.False(enemy.IsAlive);
        }

        [Fact]
        public void Heal_WhenHealIsValid30_HealthMustIncreaseBy30()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 50);

            //Act
            enemy.Heal(30);

            //Assert
            Assert.Equal(80, enemy.Health);
        }

        [Fact]
        public void Heal_WhenHealIsNegative5_ShouldThrowArgumentExeption()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 50);
            int healAmount = -5;

            //Act & Assert
            Assert.Throws<ArgumentException>(() => enemy.Heal(healAmount));

        }

        [Fact]
        public void Heal_WhenHeal50IsGreaterThanMaxHealth100_HealthMustBe100()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 80);
            int healAmount = 50;
            //Act
            enemy.Heal(healAmount);
            //Assert
            Assert.Equal(100, enemy.Health);
        }

        [Fact]
        public void Heal_WhenEnemyIsDead_HealthShouldRemain0AndIsAliveShouldRemainFalse()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 0);
            int healAmount = 20;

            //Act & Assert
            Assert.Equal(0, enemy.Health);
            Assert.Equal(false, enemy.IsAlive);
        }

        [Fact]
        public void IsAlive_WhenHealthIsGreaterThanZero1_ShouldReturnTrue()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 1);
            //Act
            bool isAlive = enemy.IsAlive;
            //Assert
            Assert.True(isAlive);
        }

        [Fact]
        public void IsAlive_WhenHealthIsZero_ShouldReturnFalse()
        {
            //Arrange
            Enemy enemy = new Enemy("Goblin", 0);
            //Act
            bool isAlive = enemy.IsAlive;
            //Assert
            Assert.False(isAlive);
        }
    }
}