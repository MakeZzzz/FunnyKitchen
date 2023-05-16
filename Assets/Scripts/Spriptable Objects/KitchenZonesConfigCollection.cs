using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Kitchen", menuName = "Kitchen")]
    public class KitchenZonesConfigCollection : ScriptableObject
    {
        public ConfigKitchenZoneModel[] ConfigKitchenZoneModels => _configKitchenZoneModel;

        [SerializeField] private ConfigKitchenZoneModel[] _configKitchenZoneModel;
    }
}