using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ConfigKitchenZoneModel
{
    public string NameZone => _nameZone;
    public ConfigImprovementModel[] ConfigImprovement => _configImprovement;
    public ConfigItemModel[] ConfigItem => _configItem;
    
    [SerializeField] private string _nameZone;
    [SerializeField] private ConfigImprovementModel[] _configImprovement;
    [SerializeField] private ConfigItemModel[] _configItem;
    
}
