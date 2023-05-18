using System;
using UnityEngine;
using UnityEngine.UI;

namespace Client
{
    public class TimeController : MonoBehaviour
    {
        public Action OnSliderReady;

        [SerializeField] private ClientView _clientView;
        [SerializeField] private float _value = 1f;
        [SerializeField] private MovementClientController _client;

        private Slider _slider;

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
            _slider.value -= 5f;

           // Debug.Log(_slider.value);

            if (_slider.value == 10)
            {
                _clientView.OnOrderNotReady.Invoke();
            }

            if (Math.Round(_slider.value, 1) == 0)
            {
                //Debug.Log(_slider.value);
                _clientView.OnTimeIsOver.Invoke();
                _client.OnOrderNotReady.Invoke();
            }
        }
    }
}