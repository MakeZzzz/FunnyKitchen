using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  ScriptableObjects
{
    [CreateAssetMenu(fileName = "Kitchen", menuName = "Kitchen")]
    public class KitchenZonesConfigCollection :  ScriptableObject
    {
        [SerializeField] private ConfigKitchenZoneModel[] _configKitchenZoneModel;
    }
}

