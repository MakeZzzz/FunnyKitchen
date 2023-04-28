using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientController : MonoBehaviour
{
    [SerializeField] private ClientSystem _customer;
   
    public Action OnChangeOrder;
    private GameObject _createdObject;
    private readonly ClientSystem model;
    private readonly ClientView view;

    private void Awake()
    {
        _customer.ClientСame += CreateOrderUI;
    }
    public void CreateOrderUI()
    {
        OnChangeOrder.Invoke();
    }
    public ClientController(ClientSystem model, ClientView view)
    {
        this.model = model;
        this.view = view;
        // Подписываемся на событие создания игрока в модели
        model.OnPlayerCreated += OnPlayerCreated;
    }

    private void OnPlayerCreated(GameObject player)
    {
        // Передаем игрока в представление
        view.SetPlayer(player);
    }
}
