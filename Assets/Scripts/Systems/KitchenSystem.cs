using System;
using System.Collections.Generic;
using UnityEngine;

namespace Systems
{
    public class KitchenSystem : MonoBehaviour
    {
        [SerializeField] private KitchenZoneController _colaMakerPrefab;
        [SerializeField] private KitchenZoneController _kitchenStovePrefab;
        [SerializeField] private KitchenZoneController _platePrefab;

        [SerializeField] private  List<Transform> _colaMakerPoints = new ();
        [SerializeField] private  List<Transform> _kitchenStovePoints = new ();
        [SerializeField] private  List<Transform> _platePoints = new ();


        private void Start()
        {
            SpawnKitchenZone(_colaMakerPrefab,_colaMakerPoints);
            SpawnKitchenZone(_kitchenStovePrefab,_kitchenStovePoints);
            SpawnKitchenZone(_platePrefab,_platePoints);
        }

        public void SpawnKitchenZone(KitchenZoneController prefab, List<Transform> position)
        {
            foreach (var currentPosition in position)
            {
                var kitchenZone = Instantiate(prefab,currentPosition);
            }
        }
        
        // public void DeleteControllers()
        // {
        //     foreach (var controller in _controllers)
        //     {
        //         Destroy(controller.gameObject);
        //     }
        //     _controllers.Clear();
        // }
        
    }
}
