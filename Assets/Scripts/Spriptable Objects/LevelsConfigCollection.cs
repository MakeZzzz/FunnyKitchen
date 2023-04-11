using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "Levels", menuName = "Levels")]
    public class LevelsConfigCollection : ScriptableObject
    {
        [SerializeField] private ConfigLevelsModel[] _configLevelsModel;
        
        public ConfigLevelsModel[] ConfigLevelsModel => _configLevelsModel;
    }
}
