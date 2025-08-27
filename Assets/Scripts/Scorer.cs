using UnityEngine;
using UnityEngine.InputSystem;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into things this many times: " + hits);
        }
    }
}
