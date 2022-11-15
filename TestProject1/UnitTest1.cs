using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //comparison [8,10]
        [TestMethod]
        public void IsScoreEqualEight_Grade_A()
        {
            Student s = new Student();
            s.Score = 8;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void IsScoreEqualTen_Grade_A()
        {
            Student s = new Student();
            s.Score = 10;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);
        }
    }
}