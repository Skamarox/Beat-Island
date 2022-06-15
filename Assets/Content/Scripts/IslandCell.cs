using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IslandCell : MonoBehaviour, IDetector
{
    [SerializeField] private int HumanCount;
    [SerializeField] private const int MaxHumanCount = 10;
    [SerializeField] private TMP_Text CountText;
    [SerializeField] private IslandCell nextCell;
    [SerializeField] private HumanCountText humanCountText;
    [SerializeField] private GameObject[] Environment;
    [SerializeField] private GameObject Icon;

    void Start() 
    {
        ActivateEnvironmentObjects();
        Icon.SetActive(false);
    }

    public void SetNextCell(IslandCell cell)
    {
        nextCell = cell;
    }

    public int GetCount() 
    {
        int count = HumanCount;
        return count;
    }

    public void HumanClear() 
    {
        humanCountText.ChangeText(-HumanCount);
        HumanCount = 0;
        ActivateEnvironmentObjects();
        Icon.SetActive(false);
        ChargeText("");
    }

    public void Detect(GameObject human)
    {
        AddHuman();
        human.SetActive(false);
    }

    public void AddHuman()
    {
        if (nextCell == null)
        {
            HumanCount++;
            humanCountText.ChangeText(1);
        }
        else if (HumanCount >= MaxHumanCount)
            nextCell.AddHuman();
        else
        {
            HumanCount++;
            humanCountText.ChangeText(1);
            ActivateEnvironmentObjects();
        }
        ChargeText(HumanCount.ToString());
        Icon.SetActive(true);
    }

    private void ChargeText(string message) 
    {
        CountText.text = message;
    }

    private void ActivateEnvironmentObjects() 
    {
        for(int i = 0; i < Environment.Length; i++)
        {
            if (i < HumanCount)
                Environment[i].SetActive(true);
            else
                Environment[i].SetActive(false);
        }
    }
}
