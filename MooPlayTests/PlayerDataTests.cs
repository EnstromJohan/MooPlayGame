namespace MooPlayTests
{
    [TestClass]
    public class PlayerDataTests
    {
        [TestMethod]
        //Test för average när ingen omgång har körts, skall returnera 0.
        public void Test_AverageNoGamesPlayed()
        {
            //Arrange
            var playerData = new PlayerData("Johan", 0);

            //Act
            var average = playerData.Average;

            //Assert
            Assert.AreEqual(0, average);
        }

        [TestMethod]
        //Test för average när omgång har körts, skall retuerna korrekt värde.
        public void Test_AverageGamesPlayed()
        {
            //Arrange
            var playerData = new PlayerData("Johan", 3);
            playerData.Update(1);

            //Act
            var average = playerData.Average;

            //Assert
            Assert.AreEqual(2, average);

        }
    }
}
