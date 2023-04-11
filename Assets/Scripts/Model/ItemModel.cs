using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ItemModel
{
    public string Name => _name;
    public int CookingTime => _cookingTime;
    public int Income => _income;
   
    [SerializeField] private string _name;
    [SerializeField] private int _cookingTime;
    [SerializeField] private int _income;
}
