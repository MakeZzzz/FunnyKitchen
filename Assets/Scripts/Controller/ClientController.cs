using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientController : MonoBehaviour
{
    public Action OnChangeOrder;
    [SerializeField] private ClientSystem _customer;

    private void Awake()
    {
        _customer.OnClientArrivedAtPoint += CreateOrderUI;
    }

    public void CreateOrderUI()
    {
        OnChangeOrder.Invoke();
    }

    public GameObject ReturnPlayer()
    {
        var customer = _customer.ReturnCustomer();
        return customer;
    }
}