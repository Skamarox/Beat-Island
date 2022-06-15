using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumanCountTextRotate : MonoBehaviour
{
    public static float Rotate = 0;

    private void Start()
    {
        Rotate = 0;
        GetComponent<TMP_Text>().text = "";
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y - 60f, 30f);
        //if (Input.GetKeyDown(KeyCode.D))
        //    transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y + 60f, 30f);
    }
}
