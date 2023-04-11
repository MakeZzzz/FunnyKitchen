using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ConfigImprovementModel
{
    public int Price => _price;
    [SerializeField] private int _price;
}
