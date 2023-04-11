using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "levels", menuName = "Levels")]
    public class LevelsConfigCollection : ScriptableObject
    {
        [SerializeField] private ConfigLevelsModel[] _configLevelsModel;
        
        public ConfigLevelsModel[] ConfigLevelsModel => _configLevelsModel;
    }
}
