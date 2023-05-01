using System;
using UnityEngine;

namespace Configs
{
    [Serializable]
    public class ConfigImprovementModel
    {
        public int Price => _price;
        [SerializeField] private int _price;
    }
}
