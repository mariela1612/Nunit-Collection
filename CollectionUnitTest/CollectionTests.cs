
using Collections;

namespace CollectionUnitTest
{
    public class CollectionTests

    {
       
         [Test]
        public void Test_Collection_EmptyConstructor()
        {
            //Arrange and Act
            var nums = new Collection<int>();

            //Act
            Assert.That(nums.Count == 0, "Count property");
            Assert.That(nums.Capacity == 16, "Cpacity property");

            //Assert
            Assert.AreEqual(nums.Capacity, 16);
            Assert.AreEqual(nums.Count, 0);

        }
        [Test]
        public void Test_Collection_AddItem()
        {
            //Arrange and Act
            var nums = new Collection<int>();

            //Act
            nums.Add(5);

            //Assert
            Assert.That(nums.ToString() == "[5]");

        }
        [Test]
        public void Test_Collection_AddRange()
        {
            //Arrange and Act
            var nums = new Collection<int>();

            //Act
            nums.AddRange(new[] { 1, 2, 3 });

            //Assert
            Assert.That(nums.ToString()== "[1, 2, 3]");

        }

    }
}