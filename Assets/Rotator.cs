using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    Transform start;
    void Start()
    {
        start = transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = start.rotation;
    }
}
