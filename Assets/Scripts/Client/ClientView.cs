using System;
using System.Collections.Generic;
using Controller;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace Client
{
    public class ClientView : MonoBehaviour
    {
        public Action OnOrderNotReady;
        public Action OnTimeIsOver;
    
        [SerializeField] private Slider _slider;
        [SerializeField] private ClientController _client;
        [SerializeField] private TimeController _timeController;
        [SerializeField] private Texture[] _texturesCustomer;
        [SerializeField] private  List<Sprite> _orders;
        
        private GameObject _customer;
        private int _countForTexture = 0;
        private Canvas _canvas;
    
        private void Awake()
        {
            OnTimeIsOver += ChangeTextureCustomer;
            OnOrderNotReady += ChangeTextureCustomer;
            _client.OnChangeOrder += CreateOrder;
            _client.OnDeliteClient += CustomerReturnAtStart;
        }

        private void Start()
        {
            InitializeCustomer();
        }

        private void InitializeCustomer()
        {
            _customer = _client.ReturnCustomer();
        }
    
        private void InitializeCanvas()
        {
            _canvas = _customer.GetComponentInChildren<Canvas>();
            _canvas.enabled = true;
        }
        private void InitializeSlider()
        {
            var slider = Instantiate(_slider, _canvas.transform);
            Initialize(slider);
        }

        private void CreateOrder()
        {
            InitializeCustomer();
            InitializeCanvas();
            InitializeSlider();

            _timeController.OnSliderReady.Invoke();
        
            var grid = _customer.GetComponentInChildren<GridLayoutGroup>();

            var countOfOrders = ReturnRandomIndex() + 1;
            
            for (int i = 0; i < countOfOrders; i++)
            {
                var index = ReturnRandomIndex();
                
                if (_orders[index] == null)
                {
                    index = ReturnRandomIndex();
                }
                
                GameObject newElement = new GameObject();
                newElement.AddComponent<Image>().sprite = _orders[index];
                var child = Instantiate(newElement, grid.transform);
                
                _orders.Remove(_orders[index]);
            }
        }

        private void Initialize(Slider slider)
        {
            _slider = slider;
        }

        public Slider ReturnSlider()
        {
            return _slider;
        }

        private void ChangeTextureCustomer()
        {
            _customer.GetComponent<RawImage>().texture = _customer.GetComponent<PrefabsTextures>().Textures[_countForTexture];
            
            if (_countForTexture != _texturesCustomer.Length - 1)
            {
                _countForTexture++;
            }
        }
        private int ReturnRandomIndex()
        {
            return Random.Range(0, _orders.Count);
        }
        private void CustomerReturnAtStart()
        {
            _customer.SetActive(false);
        }
    }
}