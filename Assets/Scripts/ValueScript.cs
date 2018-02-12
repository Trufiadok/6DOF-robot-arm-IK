using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueScript : MonoBehaviour
{
    public bool Clamp5;

    private Text textValue;
    private Slider slider;

    // Use this for initialization
    void Start()
    {
        textValue = transform.Find( "TextValue" ).GetComponent<Text>();
        slider = transform.GetComponent<Slider>();

        UpdateValue();
    }

    public void UpdateValue()
    {
        if ( Clamp5 )
            slider.value = ( (int)slider.value / 5 ) * 5;

        if( textValue != null )
            textValue.text = slider.value.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
