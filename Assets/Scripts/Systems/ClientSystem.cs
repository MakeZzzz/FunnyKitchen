using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ClientSystem : MonoBehaviour
{
    public Action ClientСame;
    [SerializeField] private List<Transform> _startPositions;
    [SerializeField] private List<Transform> _endPositions;
    [SerializeField] private List<GameObject> _custumersPrefabs;
    [SerializeField] private Canvas _canvas;
    private Transform _startPosition;
    private Transform _endPosition;
    private GameObject _custumer;

    public float speed = 1.0f;
    private float _startTime;
    private float _journeyLength;

    private void Awake()
    {
        SetStartPosition();
        SetEndPosition();
        _startTime = Time.time;
        _journeyLength = Vector3.Distance(_startPosition.position, _endPosition.position);
        CreateNewCustomer();
    }

    private void Update()
    {
        MovingCustomer();
        //if (_custumer != null)
        //{
        //}

        //if (_custumer == null)
        //{
        //    CreateNewCustomer();
        //}
    }

    private void SetStartPosition()
    {
        var index = Random.Range(0, _startPositions.Count);
        _startPosition = _startPositions[index];
    }

    private void CreateNewCustomer()
    {
        var index = Random.Range(0, _custumersPrefabs.Count);
        _custumer = Instantiate(_custumersPrefabs[index], _startPosition);
        _custumer.transform.SetParent(_canvas.transform, false);
        var canvas = _custumer.GetComponentInChildren<Canvas>();
        canvas.enabled = false;
        }

    private void SetEndPosition()
    {
        var index = Random.Range(0, _endPositions.Count);
        _endPosition = _endPositions[index];
    }

    public void MovingCustomer()
    {
        var distCovered = (Time.time - _startTime) * speed;
        var fracJourney = distCovered / _journeyLength;

        _custumer.transform.position = Vector3.Lerp(_startPosition.position, _endPosition.position, fracJourney);

        if (_custumer.transform.position == _endPosition.position)
        {
            ClientСame.Invoke();
        }
    }

    public GameObject ReturnCustomer()
    {
        return _custumer;
    }
}