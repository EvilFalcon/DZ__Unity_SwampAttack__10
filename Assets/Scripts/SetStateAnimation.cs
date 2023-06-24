using UnityEngine;

public class SetStateAnimation : MonoBehaviour
{
    [SerializeField] private GameObject _cow;
    private const string State = "State";

    public void SetIdle()
    {
        _cow.GetComponent<Animator>().SetInteger(State, 0);
    }

    public void SetWalk()
    {
        _cow.GetComponent<Animator>().SetInteger(State, 1);
    }

    public void SetRun()
    {
        _cow.GetComponent<Animator>().SetInteger(State, 2);
    }
}