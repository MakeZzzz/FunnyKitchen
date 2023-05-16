using System.Collections.Generic;
using UnityEngine;

namespace Client
{
    public class PointsForClient : MonoBehaviour
    {
        public List<Transform> StartPositions => _startPositions;
        [SerializeField] private List<Transform> _startPositions;
        public List<Transform> EndPositions =>_endPositions;
        [SerializeField] private List<Transform> _endPositions;
    }
}
