using System;
using TMPro;
using UnityEngine;

public class BalanceView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _totalBalance;
    
    private ProfitSystem _profitSystem;

    private void Start()
    {
        _profitSystem = FindObjectOfType<ProfitSystem>();
    }

    private void Update()
    {
        var balance = Convert.ToInt32(_profitSystem.GetBalance().ToString());
        _totalBalance.text = balance + "$";
    }
    public void Initialize(ProfitSystem profitSystem)
    {
        _profitSystem = profitSystem;
    }
}
