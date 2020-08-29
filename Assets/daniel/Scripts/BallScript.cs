using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField]
    private float speenFactor = 1.5f;

    private bool inAir = false;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        inAir = false;
    }
    void Update()
    {
        inAir = gameObject.transform.GetComponent<Rigidbody>().useGravity;
        if (inAir)
        {
            //    transform.Rotate(transform.right, speenFactor);
            transform.RotateAround(transform.position, transform.right, speenFactor);
        }
    }

}
