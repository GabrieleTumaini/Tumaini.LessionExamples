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




    }
}