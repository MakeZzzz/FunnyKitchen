using System;
using UnityEngine;
using UnityEngine.UI;

namespace Controller
{
    public class TimeController : MonoBehaviour
    {
        public Action OnSliderReady;
    
        [SerializeField] private ClientView _clientView;
        [SerializeField] private float _value = 1f;
    
        private Slider _slider;
        private GameObject _client;
    
        private void Awake()
        {
            OnSliderReady += GetSlider;
        }

        private void GetSlider()
        {
            _slider = _clientView.ReturnSlider();
            InvokeRepeating("CountDown", 1f, 1f);
        }

        private void CountDown()
        {
            _slider.value -= 1f;

            if (Math.Round(_slider.value, 1) == _value / 2)
            {
                _clientView.OnOrderNotReady.Invoke();
            }
        
            if (Math.Round(_slider.value, 1) ==0)
            {
                _clientView.OnTimeIsOver.Invoke();
            }
        }
    }
}