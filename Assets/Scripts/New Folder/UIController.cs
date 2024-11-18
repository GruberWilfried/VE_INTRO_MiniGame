using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider slider;
    public Light light;
    public Toggle toggle;
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = slider.value * 2;
        sphere.active = toggle.isOn;
    }
}
