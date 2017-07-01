using System.Threading.Tasks;

namespace Fibon.Messages.Events
{
    public interface IEvent
    {
         
    }

    public interface IEventHandler<in T> where T:IEvent{
        Task HandleAsync(T @event);
    }

    public class ValueCalculatedEvent : IEvent{
        public int Number { get; private set; }
        public int Value { get; private set; }

        public ValueCalculatedEvent()
        {
            
        }

        public ValueCalculatedEvent(int number, int value){
            Number = number;
            Value = value;
        }
    }
}