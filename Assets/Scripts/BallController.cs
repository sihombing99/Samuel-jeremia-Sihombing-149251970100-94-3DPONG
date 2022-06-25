using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    
    private Rigidbody rig;
    private Vector3 initPos;
    private Vector3 initSpeed;
    public BallManager manager;
    private bool outOfArea;

    public float maxSpeed;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        rig.velocity = speed;
        initPos = gameObject.transform.position;
        initSpeed = speed;
        outOfArea = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "pemain" || collision.gameObject.tag == "sudut")
        {
            if (rig.velocity.magnitude < maxSpeed)
            {
                rig.velocity = rig.velocity.normalized * maxSpeed;
            }
        }
        else if(collision.gameObject.tag == "plane")
        {
            rig.constraints = RigidbodyConstraints.FreezePositionY;
        }
    }

    public void ResetPosition()
    {
        manager.RemoveBall(gameObject);
    }

}
