using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientController : MonoBehaviour
{
    [SerializeField] private ClientSystem _customer;
   
    public Action OnChangeOrder;
    private GameObject _createdObject;
    [SerializeField]public ClientSystem model;
    private readonly ClientView view;

    private void Awake()
    {
        _customer.ClientСame += CreateOrderUI;
    }
    public void CreateOrderUI()
    {
        OnChangeOrder.Invoke();
    }

    public GameObject ReturnPlayer()
    {
        var customer = model.ReturnCustomer();
        return customer;
    }
}
