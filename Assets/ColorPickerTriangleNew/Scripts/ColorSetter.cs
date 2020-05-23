using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSetter : MonoBehaviour
{

    private Image itemPanel;
    private Text[] itemsText;
    private Text[] itemsButton;
    public ColorPickerTriangle cpPanel;
    public ColorPickerTriangle cpText;
    public ColorPickerTriangle cpButton;

    //public GameObject ColoringObject;

    void Start()
    {
        itemPanel = GameObject.FindGameObjectWithTag("Panel").GetComponent<Image>();
        itemsText = FindObjectsOfType(typeof(Text)) as Text[];

        //cpText = ColoringObject.GetComponent<ColorPickerTriangle>();
        //cpText = ColoringObject.GetComponent<ColorPickerTriangle>();
    }

    void Update()
    {
        if (Input.anyKey)
        {
            itemPanel.color = cpPanel.TheColor;
            foreach (Text item in itemsText)
            {
                item.color = cpText.TheColor;
            }
        }
    }
}
