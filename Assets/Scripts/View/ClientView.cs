using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ClientView : MonoBehaviour
{
    private Action OnCreateNewOrder;
    
    private GameObject _customer;
    [SerializeField] private List<GameObject> _orders;
    [SerializeField] private Slider _slider;
    [SerializeField] private ClientController _client;

    private void Awake()
    {
        OnCreateNewOrder += CreateOrder;
        _client.OnChangeOrder += CreateOrder;
    }

    private void CreateOrder()
    {
        _customer = _client.ReturnPlayer();

        ReturnSlider();
        var order = Instantiate(_orders[0]);
        order.transform.SetParent(_customer.transform);
        Debug.Log("Order: "+ _orders[0]);
        Debug.Log(_customer.name);
      }
    //public void SetPlayer(GameObject player)
    //{
    //    _customer = player;
    //}

    public Slider ReturnSlider()
    {
        var canvas =_customer.GetComponentInChildren<Canvas>();
        canvas.enabled = true;

        var slider = Instantiate(_slider, canvas.transform);
        return slider;
    }
}
