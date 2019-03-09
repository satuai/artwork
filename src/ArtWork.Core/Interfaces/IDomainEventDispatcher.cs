using ArtWork.Core.SharedKernel;

namespace ArtWork.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}