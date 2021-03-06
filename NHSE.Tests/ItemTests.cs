using FluentAssertions;
using NHSE.Core;
using Xunit;

namespace NHSE.Tests
{
    public class ItemTests
    {
        [Fact]
        public void ItemMarshal()
        {
            var item = new Item();
            var bytes = item.ToBytesClass();
            bytes.Length.Should().Be(Item.SIZE);
        }

        [Fact]
        public void VillagerItemMarshal()
        {
            var item = new VillagerItem();
            var bytes = item.ToBytesClass();
            bytes.Length.Should().Be(VillagerItem.SIZE);
        }

        [Fact]
        public void MapItemMarshal()
        {
            var item = new MapItem();
            var bytes = item.ToBytesClass();
            bytes.Length.Should().Be(MapItem.SIZE);
        }
    }
}
