using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void TestBS()
        {

           
            int[] numbers = { 5,2,8,4,1,6};
            int[] ready_numbers = { 1,2,4,5,6,8};
            Program.BubbleSort(numbers);
            CollectionAssert.AreEqual(numbers, ready_numbers);
        }
        [TestMethod]
        public void TestQS()
        {


            int[] numbers = { 5, 2, 8, 4, 1, 6 };
            int[] ready_numbers = { 1, 2, 4, 5, 6, 8 };
            Program.QuickSort(numbers);
            CollectionAssert.AreEqual(numbers, ready_numbers);

        }
    }
}
