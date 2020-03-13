using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSetter : MonoBehaviour
{
    public GameObject ColoringObject;
    private ColorPickerTriangle CP;
    private bool isPaint = false;
    //private GameObject go;
    private Material mat;

    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;

        //go = (GameObject)Instantiate(ColoringObject, transform.position + Vector3.up * 1.4f, Quaternion.identity);
        //ColoringObject.transform.localScale = Vector3.one * 1.3f;
        //ColoringObject.transform.LookAt(Camera.main.transform);
        CP = ColoringObject.GetComponent<ColorPickerTriangle>();
        CP.SetNewColor(mat.color);
    }

    void Update()
    {
        mat.color = CP.TheColor;
    }
}
