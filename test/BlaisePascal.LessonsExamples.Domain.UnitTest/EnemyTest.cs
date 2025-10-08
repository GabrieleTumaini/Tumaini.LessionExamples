namespace BlaisePascal.LessonsExamples.Domain.UnitTest
{
    public class EnemyTest
    {
        [Fact]
        public void EnemyName_WhenTheNameIsValid_NameMustBeAssignedCorrectly()
        {
            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetName("Stefano");

            //Assert
            Assert.Equal("Stefano", newEnemy.GetName());
        }

        [Fact]
        public void EnemyName_TheNameCannotBeNull()
        {
        
            //Arrange
            Enemy newEnemy = new Enemy();

            //Assert
             Assert.Null(newEnemy.GetName());
         }

        [Fact]
        public void EnemyName_TheNameCannotBeEmpty()
        {

            //Arrange
            Enemy newEnemy = new Enemy();

            //Act
            newEnemy.SetName("");

            //Assert
            Assert.Empty(newEnemy.GetName());
        }
    }
}