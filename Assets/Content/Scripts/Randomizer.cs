using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour
{
    [SerializeField] private List<Transform> SpawnPoints = new List<Transform>();

    public List<Transform> GetSpawnWave() 
    {
        int Index = 0;
        int IndexMax = 2;
        List<Transform> Temp = new List<Transform>();
        while(Index < IndexMax)
        {
            int random = Random.Range(0, SpawnPoints.Count);
            Temp.Add(SpawnPoints[random]);
            Index++;
        }
        return Temp;
    }
}
