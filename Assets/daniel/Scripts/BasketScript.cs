using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketScript : MonoBehaviour
{
    [SerializeField]
    private float basketSpeed = 0.5f;

    private float basketDirection = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   //     transform.position = new Vector3(transform.position.x - basketSpeed*basketDirection, transform.position.y, transform.position.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.name.Contains("Right wall")|| collision.collider.gameObject.name.Contains("Left wall"))
        {
            setBasketdirction();
        }
    }

    private void setBasketdirction()
    {
        basketSpeed = basketSpeed * -1;
    }

    public void setBasketSpeed(float newBasketSpeed)
    {
        basketSpeed = newBasketSpeed;
    }
}
