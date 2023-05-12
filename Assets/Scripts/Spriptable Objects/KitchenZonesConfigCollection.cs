using Configs;
using UnityEngine;

namespace Spriptable_Objects
{
    [CreateAssetMenu(fileName = "Kitchen", menuName = "Kitchen")]
    public class KitchenZonesConfigCollection : ScriptableObject
    {
        public ConfigKitchenZoneModel[] ConfigKitchenZoneModels => _configKitchenZoneModel;

        [SerializeField] private ConfigKitchenZoneModel[] _configKitchenZoneModel;
    }
}