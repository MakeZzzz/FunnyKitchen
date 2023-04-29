using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ClientView : MonoBehaviour
{
    private GameObject _customer;
    //[SerializeField] private List<GameObject> _custumersPrefabs;
    [SerializeField] private List<GameObject> _orders;
    [SerializeField] private Canvas _canvas;
    [FormerlySerializedAs("_sl")] [SerializeField] private Slider _slaider;
    [SerializeField] private Transform _pointsForOrder;
    public Action Come;
    [SerializeField] private ClientController _client;
    //public ClientController OnChangeOrder;

    private void Awake()
    {
        Come += CreateOrder;
        _client.OnChangeOrder += CreateOrder;
    }

    private void CreateOrder()
    {
        _customer = _client.ReturnPlayer();
        
        var canvas =_customer.GetComponentInChildren<Canvas>();
        canvas.enabled = true;

        var slaider = Instantiate(_slaider, canvas.transform);
        var order = Instantiate(_orders[0]);
        order.transform.SetParent(_customer.transform);
        Debug.Log("Order: "+ _orders[0]);
        Debug.Log(_customer.name);
        
      }
    public void SetPlayer(GameObject player)
    {
        _customer = player;
    }
}
