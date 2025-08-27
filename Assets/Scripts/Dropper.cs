using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;

    MeshRenderer myMyeshRenderer;
    Rigidbody    myRigidBody;

    void Start()
    {
        myMyeshRenderer         = GetComponent<MeshRenderer>();
        myRigidBody             = GetComponent<Rigidbody>();
        myMyeshRenderer.enabled = false;
        myRigidBody.useGravity  = false;
    }

    void Update()
    {
        if (Time.time > timeToWait)
        {
            myMyeshRenderer.enabled = true;
            myRigidBody.useGravity  = true;
        }
    }
}
