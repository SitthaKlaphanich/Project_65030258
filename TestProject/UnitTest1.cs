using Project_65030258;
namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestProjectMembersCount()
        {
            Assert.IsTrue(Enum.GetNames(typeof(Project.Members)).Length == 4);
        }
        [TestMethod]
        public void TestProjectMemberIds()
        {
            Assert.IsTrue((int)Project.Members.Joe == 1);
            Assert.IsTrue((int)Project.Members.Jane == 2);
            Assert.IsTrue((int)Project.Members.Mark == 3);
        }
    }
}