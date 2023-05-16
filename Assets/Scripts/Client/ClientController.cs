using System;
using Client;
using Systems;
using UnityEngine;

namespace Client
{
    public class ClientController : MonoBehaviour
    {
        public Action OnChangeOrder;
        public Action OnDeliteClient;
        [SerializeField] private MovementClientController _customer;

        private void Start()
        {
            _customer.OnClientArrivedAtPoint += CreateOrderUI;
            _customer.OnClientGoAway += DeliteClient;
        }

        public void CreateOrderUI()
        {
            OnChangeOrder.Invoke();
        }
        public void DeliteClient()
        {
            OnDeliteClient.Invoke();
        }
        public GameObject ReturnCustomer()
        {
            var customer = _customer.ReturnCustomer();
            return customer;
        }
    }
}