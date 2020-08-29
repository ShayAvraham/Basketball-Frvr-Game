using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.iOS;
using UnityEngine;

public class MainCameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float cameraMovementFactor =0.5f;

    private Vector3 lastMousePosition = Vector3.zero;
    private Vector3 deltaMousePosition = Vector3.zero;

    private Vector3 shootDirection;

    private Vector3 throwSpeed = new Vector3(0, 26, 40);

    [SerializeField]
    private Vector3 pos;

    [SerializeField]
    float ball_speed_factor = 10f;

    [SerializeField]
    private Transform prefab_ball;

    private Transform ballTrans = null;
    private Rigidbody ballRB = null;

    void Start()
    {
        Cursor.visible = false;
        lastMousePosition = Input.mousePosition;
    }

    // Update is called once per frame

    void Update()
    {
        deltaMousePosition = lastMousePosition - Input.mousePosition;
        lastMousePosition = Input.mousePosition;
        transform.Rotate(transform.up, -deltaMousePosition.x * cameraMovementFactor);


        if (Input.GetMouseButtonDown(0))
        {
            ballTrans = Instantiate(prefab_ball, transform.position + pos, Quaternion.identity);
            ballRB = ballTrans.GetComponent<Rigidbody>();
            ballTrans.parent = gameObject.transform;
            ballRB.useGravity = false;
        }
        if(Input.GetMouseButtonUp(0))
        {

            Destroy(ballTrans.gameObject, 10f);
            Ray myray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //      Vector3 shootDirection = new Vector3(myray.direction.x , ballTrans.transform.position.y + 4, ballTrans.transform.position.z * -1f);
            Vector3 shootDirection = new Vector3(Camera.main.transform.position.x, ballTrans.transform.position.y + 4, ballTrans.transform.position.z * -1f);
            ballRB.useGravity = true;
            ballRB.AddForce(shootDirection * ball_speed_factor);
            ballTrans.parent = null;
        }
    }
}
