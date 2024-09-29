using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADS : MonoBehaviour
{
    [SerializeField] private Transform _ADSTransform;
    [SerializeField] private Transform _hipFireTransform;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            print("Pressed");
            transform.position = _ADSTransform.position;
        }
        else
        {
            print("Not pressed");
            transform.position = _hipFireTransform.position;
        }
    }
}
