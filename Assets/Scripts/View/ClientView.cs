using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ClientView : MonoBehaviour
{
    private Action OnCreateNewOrder;
    public Action OnOrderNotReady;
    public Action OnTimeIsOver;

    //[SerializeField] private List<GameObject> _orders;
    [SerializeField] private Slider _slider;
    [SerializeField] private ClientController _client;
    [SerializeField] private TimeController _timeController;
    [SerializeField] private Texture[] _texturesCustomer;
    [SerializeField] private Sprite[] _order;
    private GameObject _customer;
    private int _countForTexture = 0;

    private void Awake()
    {
        OnTimeIsOver += SetNewTexture;
        OnOrderNotReady += SetNewTexture;
        OnCreateNewOrder += CreateOrder;
        _client.OnChangeOrder += CreateOrder;
    }

    private void CreateOrder()
    {
        _customer = _client.ReturnPlayer();

        var canvas = _customer.GetComponentInChildren<Canvas>();
        canvas.enabled = true;

        var slider = Instantiate(_slider, canvas.transform);
        Initialize(slider);

        _timeController.OnSliderReady.Invoke();
        
        var grid = _customer.GetComponentInChildren<GridLayoutGroup>();
        
    }

    private void Initialize(Slider slider)
    {
        _slider = slider;
    }

    public Slider ReturnSlider()
    {
        return _slider;
    }

    private void SetNewTexture()
    {
        _customer.GetComponent<RawImage>().texture = _texturesCustomer[_countForTexture];
        if (_countForTexture != _texturesCustomer.Length - 1)
        {
            _countForTexture++;
        }
    }
}