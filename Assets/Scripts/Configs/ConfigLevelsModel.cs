using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ConfigLevelsModel
{
    public int LevelCount => _levelCount;
    public int FinalPriceLevel => _finalPriceLevel;
    public int MinCustomerArrivalTime => _minCustomerArrivalTime;
    public int MaxCustomerArrivalTime => _maxCustomerArrivalTime;
    
    [SerializeField] private int _levelCount;
    [SerializeField] private int _finalPriceLevel;
    [SerializeField] private int _minCustomerArrivalTime;
    [SerializeField] private int _maxCustomerArrivalTime;
}
