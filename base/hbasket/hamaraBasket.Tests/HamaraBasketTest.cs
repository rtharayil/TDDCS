using NUnit.Framework;
using System.Collections.Generic;

namespace hamaraBasket
{
    [TestFixture]
    public class HamaraBasketTest
    {
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            HamaraBasket app = new HamaraBasket(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
