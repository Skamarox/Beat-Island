using UnityEngine;
using UnityEngine.Events;

public class RoundManager : MonoBehaviour
{
    [SerializeField] private UnityEvent _Start;
    [SerializeField] private UnityEvent _End;

    private void Start()
    {
        Invoke(0);
    }

    public void AddListener(UnityAction action, int Group)
    {
        if(Group == 0)
            _Start.AddListener(action);
        else
            _End.AddListener(action);
    }

    public void Invoke(int Group)
    {
        if (Group == 0)
            _Start.Invoke();
        else
            _End.Invoke();
    }

}
