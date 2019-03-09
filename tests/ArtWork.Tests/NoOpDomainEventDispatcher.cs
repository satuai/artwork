using ArtWork.Core.Interfaces;
using ArtWork.Core.SharedKernel;

namespace ArtWork.Tests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public void Dispatch(BaseDomainEvent domainEvent) { }
    }
}
