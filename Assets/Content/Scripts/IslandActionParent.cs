using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandActionParent : MonoBehaviour
{
    [SerializeField] protected IslandCell[] cell;

    public virtual void StartAction() { }
}
