using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Client
{
    public class ClientSpawnerSystem : MonoBehaviour
    {
        [SerializeField] private List<GameObject> _custumersPrefabs;
        [SerializeField] private Canvas _canvas;

        private Transform _startPosition;
        private GameObject _customer;

        private void Awake()
        {
            CreateNewCustomer();
        }

        private void CreateNewCustomer()
        {
            var index = Random.Range(0, _custumersPrefabs.Count);
            _customer = Instantiate(_custumersPrefabs[index], _startPosition);
            _customer.transform.SetParent(_canvas.transform, false);

            //TODO эту часть надо перенести в ClientView
            var canvas = _customer.GetComponentInChildren<Canvas>();
            canvas.enabled = false;
        }

        public GameObject ReturnCustomer()
        {
            return _customer;
        }
    }
}