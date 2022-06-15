using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] protected float Speed;
    public Transform Target;
    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }

    void Update()
    {
        if (Target == null)
            return;
        float Distance = (Target.position - transform.position).magnitude;
        Speed = Distance / 4f;
        myTransform.position = Vector3.MoveTowards(myTransform.position, Target.position, Speed * Time.deltaTime);
    }
}
