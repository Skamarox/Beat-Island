using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandRotate : MonoBehaviour
{

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + 60f, 0);
        if (Input.GetKeyDown(KeyCode.S))
            transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y - 60f, 0);
    }
}
