using System.Collections.Generic;
using ScriptableObjects;
using UnityEngine;

namespace Controller
{
    public class FoodSpawner : MonoBehaviour
    {
        [SerializeField]
        private KitchenZonesConfigCollection _configKitchenZoneModel;
        [SerializeField]
        private List<Transform> _platePoint;
        [SerializeField]
        private List<Transform> _colaMakerPoint;
        [SerializeField]
        private List<Transform> _burnerPosition;
        
        void Start()
        {
            var prefab = _configKitchenZoneModel.ConfigKitchenZoneModels[0];
            
            foreach (var colaMakerPoint in _colaMakerPoint)
            {
                var food = Instantiate(prefab.Prefab, colaMakerPoint, true);
                food.transform.position = colaMakerPoint.position;
            }
            prefab = _configKitchenZoneModel.ConfigKitchenZoneModels[1];
            foreach (var platePoint in _platePoint)
            {
                var food = Instantiate(prefab.Prefab, platePoint, true);
                food.transform.position = platePoint.position;
            }
            prefab = _configKitchenZoneModel.ConfigKitchenZoneModels[2];
            foreach (var burnerPosition in _burnerPosition)
            {
                var food = Instantiate(prefab.Prefab, burnerPosition, true);
                food.transform.position = burnerPosition.position;
            }
        }
    }
}
