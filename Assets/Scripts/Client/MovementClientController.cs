using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Client
{
    public class MovementClientController : MonoBehaviour
    {
        public Action OnClientArrivedAtPoint;
        public Action OnOrderNotReady;
        public Action OnClientGoAway;

        [SerializeField] private ClientSpawnerSystem _clientSpawnerSystem;
        [SerializeField] private Canvas _canvas;
        [SerializeField] private float speed = 1.0f;

        private Transform _startPosition;
        private Transform _endPosition;
        private GameObject _customer;

        private bool _isOrderNotReady;
        private float _startTime;
        private float _distance;
        private bool _didCustomerPlaceOrder;
        private bool _isDirectionChanged = false;

        private void Awake()
        {
            OnOrderNotReady += OrderNotReady;
        }

        private void Start()
        {
            ReturnCustomer();
            SetStartPosition();
            SetEndPosition();
            SetDistance();
        }

        private void Update()
        {
            MovingCustomer();

            if (_customer.transform.position == _endPosition.position && _didCustomerPlaceOrder == false)
            {
                OnClientArrivedAtPoint.Invoke();
                _didCustomerPlaceOrder = true;
            }

            if (_customer.transform.position == _endPosition.position && _isOrderNotReady)
            {
                ChangeDirection();
                
            }
           //if (_customer.transform.position == _startPosition.position && _isDirectionChanged == true)
           //{
           //    
           //}
            
        }

        private void ChangeDirection()
        {
            (_startPosition.position, _endPosition.position) = (_endPosition.position, _startPosition.position);

            _distance = Vector3.Distance(_startPosition.position, _endPosition.position);
            _startTime = Time.time;

            if (_customer.transform.position == _startPosition.position)
            {
                _isOrderNotReady = false;
            }
            
            _isDirectionChanged = true;
        }

        private void SetStartPosition()
        {
            var list = _canvas.GetComponent<PointsForClient>().StartPositions;
            _startPosition = list[GetRandomIndex(list)];
        }

        private void SetEndPosition()
        {
            var list = _canvas.GetComponent<PointsForClient>().EndPositions;
            _endPosition = list[GetRandomIndex(list)];
        }


        private void MovingCustomer()
        {
            var distance = (Time.time - _startTime) * speed;
            var duration = distance / _distance;

            _customer.transform.position = Vector3.Lerp(_startPosition.position, _endPosition.position, duration);
            
            
        }

        public GameObject ReturnCustomer()
        {
            _customer = _clientSpawnerSystem.ReturnCustomer();
            return _customer;
        }

        private void SetDistance()
        {
            _startTime = Time.time;
            _distance = Vector3.Distance(_startPosition.position, _endPosition.position);
        }

        private int GetRandomIndex<T>(List<T> list)
        {
            var index = Random.Range(0, list.Count);
            return index;
        }

        private void OrderNotReady()
        {
            _isOrderNotReady = true;
        }

        //private void OnTriggerEnter(Collider other)
        //{
        //    Debug.Log("gfhjjjjjjjjjbjkm");
        //    OnClientGoAway.Invoke();
        //}
    }
}