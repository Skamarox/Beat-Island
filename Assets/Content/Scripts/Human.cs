using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Move
{
    private void Start()
    {
        if(Target != null)
        transform.rotation = Quaternion.FromToRotation(transform.forward, Target.position - transform.position);
    }
}
