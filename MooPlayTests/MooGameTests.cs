namespace MooPlayTests
{
    [TestClass]
    public class MooGameTests
    {
        [TestMethod]
        //Test när gissning är giltig
        public void Test_IsGuessValid()
        {
            //Arrange
            var mooGame = new MooGame();

            //Act
            bool result = mooGame.IsGuessValid("1234");

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        //Test när gissningen är ogiltig
        public void Test_IsGuessInvalid()
        {
            //Arrange
            var mooGame = new MooGame();

            //Act
            bool result = mooGame.IsGuessValid("12345");

            //Assert
            Assert.IsFalse(result);
        }
    }
}