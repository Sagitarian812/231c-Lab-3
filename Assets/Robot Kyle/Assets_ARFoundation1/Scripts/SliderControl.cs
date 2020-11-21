using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Slider scaleSlide;
    public Slider rotation;
    public GameObject Kyle;
    // Start is called before the first frame update
    void Start()
    {
        rotation.maxValue = 360;
        rotation.minValue = 0;
        scaleSlide.minValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Kyle.transform.rotation = Quaternion.Euler(0, rotation.value, 0);
        Kyle.transform.localScale = new Vector3(scaleSlide.value, scaleSlide.value, scaleSlide.value);

    }
}
