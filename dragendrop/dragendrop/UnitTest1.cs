using dragendrop.Driver;
using dragendrop.Page;

namespace dragendrop
{
    public class Tests
    {
        DragAndDropPage dragAndDrop;

        [SetUp]
        public void Setup()
        {
            WebDriver.Initialize();
            dragAndDrop = new DragAndDropPage();
        }

        [Test]
        public void Test1()
        {
            dragAndDrop.MoveObject();
        }
    }
}