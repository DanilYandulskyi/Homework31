using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private List<AudioSource> _audioClips;
    [SerializeField] private TotalVolume _totalVolume;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
    }

    private void Update()
    {
        foreach (AudioSource audioSource in _audioClips)
        {
            if (_totalVolume.Volume == 0)
            {
                audioSource.volume = 0;
                continue;
            }
                
            audioSource.volume = _slider.value / 1 * _totalVolume.Volume;
        }
    }
}
