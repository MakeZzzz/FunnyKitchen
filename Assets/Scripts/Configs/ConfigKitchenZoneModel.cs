using System;
using System.Collections.Generic;
using Configs;
using UnityEngine;

[Serializable]
public class ConfigKitchenZoneModel
{
    public string NameZone => _nameZone;
    public ConfigImprovementModel[] ConfigImprovement => _configImprovement;
    public ConfigItemModel[] ConfigItem => _configItem;
    public GameObject Prefab => _prefab;
    public List<Transform> StartPositions => _startPositions;
    
    [SerializeField] private string _nameZone;
    [SerializeField] private ConfigImprovementModel[] _configImprovement;
    [SerializeField] private ConfigItemModel[] _configItem;
    [SerializeField] private GameObject _prefab;
    [SerializeField] private List<Transform> _startPositions = new();

}
