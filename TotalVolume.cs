using UnityEngine;
using UnityEngine.UI;

public class TotalVolume : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public float Volume => _slider.value;
}
