using System.Linq;
using ArtWork.Core.Entities;
using Xunit;

namespace ArtWork.Tests.Integration.Data
{
    public class EfRepositoryAdd : BaseEfRepoTestFixture
    {

        [Fact]
        public void AddsItemAndSetsId()
        {
            var repository = GetRepository();
            var item = new ToDoItemBuilder().Build();

            repository.Add(item);

            var newItem = repository.List<ToDoItem>().FirstOrDefault();

            Assert.Equal(item, newItem);
            Assert.True(newItem?.Id > 0);
        }
    }
}
