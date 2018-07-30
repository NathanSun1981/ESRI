using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonMenu : MonoBehaviour {

    // Use this for initialization
    [Tooltip("Sphere radius.")]
    public float SphereRadius = 1.0f;

    [Tooltip("How fast the object will move to the target position.")]
    public float MoveSpeed = 0.06f;

    [Tooltip("offset to the orignall position.")]
    public float x;


    private Vector3 targetPosition;
    private Vector3 optimalPosition;
    private float initialDistanceToCamera;

    private void Start()
    {
        //transform.position = Camera.main.transform.position + new Vector3(x, -0.1f, 2);
        //initialDistanceToCamera = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    // Update is called once per frame
    void FixedUpdate () {
        
        //button always facing camera
        Quaternion default_rotation = Quaternion.Euler(0, 0, 0);
      
        Vector3 directionToTarget = Camera.main.transform.position - transform.position;
        
        transform.rotation = Quaternion.LookRotation(-directionToTarget) * default_rotation;

        /*
        optimalPosition = Camera.main.transform.position + Camera.main.transform.forward * initialDistanceToCamera;
        Vector3 offsetDir = transform.position - optimalPosition;

        if (offsetDir.magnitude > SphereRadius)
        {
            targetPosition = optimalPosition + offsetDir.normalized * SphereRadius;

            float dist = (transform.position - targetPosition).magnitude;

            transform.position = Vector3.Lerp(transform.position, targetPosition, MoveSpeed / dist);

            transform.position += new Vector3(x, 0, 0);
       }
       */
    }
}
