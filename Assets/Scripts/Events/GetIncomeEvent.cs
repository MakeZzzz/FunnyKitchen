using EventBase = SimpleEventBus.Events.EventBase;

namespace Events
{
    public class GetIncomeEvent : EventBase
    {
        public float _profit { get; }

        public GetIncomeEvent(float profit)
        {
            _profit = profit;
        }
    }
}