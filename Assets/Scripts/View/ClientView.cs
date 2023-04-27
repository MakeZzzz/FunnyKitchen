using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ClientView : MonoBehaviour
{
    [SerializeField] private List<GameObject> _custumersPrefabs;
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
        Canvas childCanvas = GetComponentInChildren<Canvas>();
        childCanvas.enabled = true;
        var order = Instantiate(_orders[Random.Range(0, _orders.Count)] );
       
       order.transform.SetParent(_pointsForOrder[0], false);
    }
}
