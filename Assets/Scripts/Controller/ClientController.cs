using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientController : MonoBehaviour
{
    [SerializeField] private ClientSystem _customer;
   
    public Action OnChangeOrder;
    private GameObject _createdObject;
    private void Awake()
    {
        _customer.ClientСame += CreateOrderUI;
    }
    
    public void HandleGameObjectCreated(GameObject gameObject)
    {
      
    }
    
    public void CreateOrderUI()
    {
        ClientSystem observer = FindObjectOfType<ClientSystem>();
        observer.OnGameObjectCreated += HandleGameObjectCreated;
        OnChangeOrder.Invoke();
    }
}