using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    // Start is called before the first frame update
    public void Select()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Deselect()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}