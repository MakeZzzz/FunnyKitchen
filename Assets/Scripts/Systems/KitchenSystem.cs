using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Systems
{
    public class KitchenSystem : MonoBehaviour
    {
        [SerializeField] private GameObject _parent;
        
        [SerializeField] private KitchenZoneController _colaMakerPrefab;
        [SerializeField] private KitchenZoneController _kitchenStovePrefab;
        [SerializeField] private KitchenZoneController _platePrefab;

        [SerializeField] private ItemController _cutlet;
        [SerializeField] private ItemController _bun;
        [SerializeField] private ItemController _cup;
            
        [SerializeField] private  List<Transform> _colaMakerPoints = new ();
        [SerializeField] private  List<Transform> _kitchenStovePoints = new ();
        [SerializeField] private  List<Transform> _platePoints = new ();
        
        [SerializeField] private  List<Transform> _cutletPoints = new ();
        [SerializeField] private  List<Transform> _bunPoints = new ();
        [SerializeField] private  List<Transform> _cupPoints = new ();
        


        private void Start()
        {
            //OnStartSpawn();
            
        }

        // private void OnStartSpawn()
        // {
        //     KitchenSpawner(_colaMakerPrefab,_colaMakerPoints);
        //     KitchenSpawner(_kitchenStovePrefab,_kitchenStovePoints);
        //     KitchenSpawner(_platePrefab,_platePoints);
        //     KitchenSpawner(_bun,_bunPoints);
        //     KitchenSpawner(_cup,_cupPoints);
        // }
        private void KitchenSpawner(KitchenZoneModel[] models)
        {
            foreach (var kitchenZone in models)
            {
                for (int i = 0; i < kitchenZone.StartPositions.Count; i++)
                {
                    var zone = Instantiate(kitchenZone.Prefab);
                    zone.transform.SetParent(_parent.transform);
                    zone.transform.position = kitchenZone.StartPositions[i].transform.position;
                }
            }
        }
        
        // private void KitchenSpawner<T>(T prefab, List<Transform> position) where T : MonoBehaviour
        // {
        //     foreach (var currentPosition in position)
        //     {
        //         var kitchenZone = Instantiate(prefab);
        //         kitchenZone.transform.SetParent(_parent.transform);
        //         kitchenZone.transform.position = currentPosition.transform.position;
        //     }
        // }
        
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
