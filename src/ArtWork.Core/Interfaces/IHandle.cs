using ArtWork.Core.SharedKernel;

namespace ArtWork.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}