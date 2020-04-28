using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSetter : MonoBehaviour
{

    private Text[] myItems;
    private ColorPickerTriangle CP;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("ColorSetter started ");

        myItems = FindObjectsOfType(typeof(Text)) as Text[];
        foreach (Text item in myItems)
        {
            Debug.Log(item.gameObject.name);
        }

        CP = ColoringObject.GetComponent<ColorPickerTriangle>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
