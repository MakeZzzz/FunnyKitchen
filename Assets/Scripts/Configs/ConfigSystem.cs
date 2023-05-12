using System.Collections;
using System.Collections.Generic;
using Model;
using ScriptableObjects;
using Spriptable_Objects;
using UnityEngine;

public class KitchenZoneInitializer : MonoBehaviour
{
    [SerializeField] private KitchenZonesConfigCollection _kitchenZonesConfigCollection;

    private KitchenZoneModel[] _kitchenZoneModels;
    
    public void CreateKitchenModels()
    {
        _kitchenZoneModels = new KitchenZoneModel[_kitchenZonesConfigCollection.ConfigKitchenZoneModels.Length];

        for (var i = 0; i < _kitchenZonesConfigCollection.ConfigKitchenZoneModels.Length; i++)
        {
            var kitchenZone = _kitchenZonesConfigCollection.ConfigKitchenZoneModels[i];
            //var businessImproves = CreateBusinessImproveModels(i);

          //  _kitchenZoneModels[i] = new KitchenZoneModel(kitchenZone.NameZone,kitchenZone.StartPositions,kitchenZone.Prefab, 
              //  kitchenZone.ConfigImprovement,kitchenZone.ConfigItem);
        }
    }

    
}
