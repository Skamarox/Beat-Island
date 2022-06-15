using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDetector
{
    void Detect(GameObject CollisionObject);
}

public class CollisionDetector : MonoBehaviour
{
    private IslandCell cell;

    private void Start()
    {
        cell = GetComponent<IslandCell>();
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Human"))
        {
            cell.Detect(collision.gameObject);
            return;
        }

            IDetector Detector = collision.GetComponent<IDetector>();
            Detector.Detect(gameObject);
    }
}
