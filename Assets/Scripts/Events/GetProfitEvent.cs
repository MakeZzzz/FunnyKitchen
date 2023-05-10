using SimpleEventBus.Events;


public class GetProfitEvent : EventBase
{
    public ProfitSystem ProfitSystem;

    public GetProfitEvent(ProfitSystem profitSystem)
    {
        ProfitSystem = profitSystem;
    }
    public ProfitSystem GetProfit()
    {
        return ProfitSystem;
    }

}
