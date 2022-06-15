using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveFabric : MonoBehaviour
{
    [SerializeField] private List<Wave> WaveList = new List<Wave>();
    [SerializeField] private RoundManager roundManager;
    private readonly float BitTime = 4f;
    private const int WaveCount = 2;
    [Range(0f, 1f)]
    [SerializeField] private float AudioDelay;

    private void Awake()
    {
        roundManager.AddListener(StartSpawn, 0);
    }

    private void StartSpawn() 
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        yield return new WaitForSeconds(AudioDelay);
        while (true)
        {
            List<Wave> Waves = new List<Wave>(WaveList);
            Waves.ForEach(x =>
            {
                x.Clear();
                x.SetPosition();
                x.gameObject.SetActive(false);
            });
            for (int i = 0; i < WaveCount; i++)
            {
                int random = Random.Range(0, Waves.Count);
                Waves[random].StartMove();
                Waves.Remove(Waves[random]);
            }
            yield return new WaitForSeconds(BitTime);
        }
    }
}
