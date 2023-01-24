
using Collections;
using NUnit.Framework.Constraints;

namespace CollectionUnitTest
{
    public class CollectionTests

    {
       
         [Test]
        public void Test_Collection_EmptyConstructor()
        {
            //Arrange
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
        [Test]
        public void Test_Collection_String()
        {
         
            var nums = new Collection<string>("QA", "Dev", "DevOPS");

            Assert.That(nums.Count == 3, "Count property");
            Assert.AreEqual(nums.Capacity, 16, "Capacity property");

            Assert.That(nums.ToString() == "[QA, Dev, DevOPS]");

        }
        [Test]
        public void Test_Collection_Remove()
        {
        
            var nums = new Collection<string>("QA", "Dev", "DevOPS");
            Assert.That(nums.Count == 3, "Count property");

            nums.RemoveAt(0);

            Assert.That(nums.Count == 2, "Count property");
            Assert.That(nums.ToString() == "[Dev, DevOPS]");
        }

        [Test]
        public void Test_Collection_Exchange()
        {
 
            var nums = new Collection<int>();

            nums.AddRange(new[] { 1, 2, 3 });

            nums.Exchange(0, 1);

            Assert.That(nums.Count == 3, "Count property");
            Assert.That(nums.ToString() == "[2, 1, 3]");
        }

        [Test]
        public void Test_Collection_OutOfRange()
        {
           var coll = new Collection<string>( "Marisa", "Elen");

            Assert.That(() => { var item = coll[5]; },
                Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test]
        public void Test_Collection_GetByIndex()
        {
            var coll = new Collection<int>( 5, 6, 7);

            var item = coll[1];

            //Assert.That(item.ToString() == "[6]");
            Assert.That(item.ToString(), Is.EqualTo("6"));
        }

        [Test]
        public void Test_Collection_SetByIndex()
        {
            var coll = new Collection<int>(5, 6, 7);

            coll[1] = 16;

            Assert.That(coll.ToString(), Is.EqualTo("[5, 16, 7]"));
        }

        [Test]
        public void Test_Collection_InsertAtIndex()
        {
            var coll = new Collection<int>(5, 6, 7);

            coll.InsertAt(1, 15);

            Assert.That(coll.ToString(), Is.EqualTo("[5, 15, 6, 7]"));
        }

        [Test]
        public void Test_Collection_Clear()
        {
            var coll = new Collection<int>(5, 6, 7);

            coll.Clear();

            Assert.That(coll.ToString(), Is.EqualTo("[]"));
        }
    }
}