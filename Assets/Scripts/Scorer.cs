using UnityEngine;
using UnityEngine.InputSystem;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    public void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("You've bumped into things this many times: " + hits);
    }
}
