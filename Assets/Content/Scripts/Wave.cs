using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : Move, IDetector
{
    [SerializeField] private Transform SpawnPos;
    [SerializeField] private WaveViewer waveViewer;
    public IslandCell cell;

    void Start()
    {
        transform.position = SpawnPos.position;
    }

    public void StartMove() 
    {
        gameObject.SetActive(true);
    }

    public void SetPosition()
    {
        transform.position = SpawnPos.position;
    }

    public void Detect(GameObject cell)
    {
        waveViewer.WaveRemove(this);
        this.cell = cell.GetComponent<IslandCell>();
    }

    public void Clear() 
    {
        cell?.HumanClear();
    }
}
