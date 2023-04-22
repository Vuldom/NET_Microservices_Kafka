using CQRS.Core.Events;

namespace Post.Common.Events
{
    public class MessageCreatedEvent : BaseEvent
    {
        public MessageCreatedEvent() : base(nameof(MessageCreatedEvent))
        {
        }

        public string Message { get; set; }
    }
}
