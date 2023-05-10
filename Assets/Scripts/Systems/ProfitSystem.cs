using Events;
using SimpleEventBus.Disposables;
using UnityEngine;

public class ProfitSystem : MonoBehaviour
{
    private float _totalBalance;
    private CompositeDisposable _subscription;
    public void IncreaseProfit(GetIncomeEvent data)
    {
        _totalBalance += data._profit;
    }
 
    private void Start()
    {
        var eventDataRequest = new GetProfitEvent(this);
        EventStream.Game.Publish(eventDataRequest);
        _subscription = new CompositeDisposable()
        {
            EventStream.Game.Subscribe<GetIncomeEvent>(IncreaseProfit),

        };
    }

    public void Initialize(float newBalance)
    {
        _totalBalance = newBalance;
    }
    
    public float GetBalance()
    {
        return _totalBalance;
    }

    public void ResetBalance()
    {
        _totalBalance = 0f;
    }
    
    public void DecreaseTotalBalance(float price)
    {
        _totalBalance -= price;
    }

    private void OnDestroy()
    {
        _subscription?.Dispose();
    }
}