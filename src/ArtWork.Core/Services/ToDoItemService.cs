using Ardalis.GuardClauses;
using ArtWork.Core.Events;
using ArtWork.Core.Interfaces;

namespace ArtWork.Core.Services
{
    public class ToDoItemService : IHandle<ToDoItemCompletedEvent>
    {
        public void Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do Nothing
        }
    }
}
