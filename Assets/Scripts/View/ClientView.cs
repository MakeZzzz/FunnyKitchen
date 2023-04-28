using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ClientView : MonoBehaviour
{
    private GameObject _customer;
    //[SerializeField] private List<GameObject> _custumersPrefabs;
    [SerializeField] private List<GameObject> _orders;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private List<Transform> _pointsForOrder;
    public Action Come;
    [SerializeField] private ClientController _client;
    public ClientController OnChangeOrder;

    private void Awake()
    {
        Come += CreateOrder;
        _client.OnChangeOrder += CreateOrder;
    }

    private void CreateOrder()
    {
        
        Debug.Log("тут будет заказ");
        Debug.Log(_customer.name);
    }
    public void SetPlayer(GameObject player)
    {
        _customer = player;
        Debug.Log(_customer.name);
    }
}
