using UnityEngine;
using UnityEngine.UI;

public class ColorSetterPanel : MonoBehaviour
{
    public GameObject ColoringObject;
    private ColorPickerTriangle CP;
    public Image image;

    void Start()
    {
        CP = ColoringObject.GetComponent<ColorPickerTriangle>();
    }

    void Update()
    {
        image.color = CP.TheColor;
    }
}
