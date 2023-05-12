using System;
using System.Collections.Generic;
using UnityEngine;

namespace Model
{
    [Serializable]
    public class KitchenZoneModel
    {
        public string NameZone => _nameZone;
        public ImprovementModel[] ConfigImprovement => _improvementModels;
        public ItemModel[] ConfigItem => _itemModels;
        public GameObject Prefab => _prefab;
        public List<Transform> StartPositions => _startPositions;

        [SerializeField] private string _nameZone;
        [SerializeField] private List<Transform> _startPositions = new();
        [SerializeField] private GameObject _prefab;
        [SerializeField] private ImprovementModel[] _improvementModels;
        [SerializeField] private ItemModel[] _itemModels;
        [SerializeField] private int _currentEquipmentQuantity;

        public KitchenZoneModel(string nameZone, List<Transform> startPositions, GameObject prefab,
            ImprovementModel[] improvementModels, ItemModel[] itemModels)
        { 
            _nameZone = nameZone;
            _startPositions = startPositions;
            _prefab = prefab;
            _improvementModels = improvementModels;
            _itemModels = itemModels;
        }
    }
}