using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_script : MonoBehaviour
{
    public float move_speed = 5;
    public float deadZone = -25;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * move_speed) * Time.deltaTime;
        
        if (transform.position.x < deadZone)
        {
            // Debug.Log("Pipe deleted.");
            Destroy(gameObject);
        }
    }
}
