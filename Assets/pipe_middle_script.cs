using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_middle_script : MonoBehaviour
{
    public logic_script logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.layer == 10)
        {
            logic.addScore(1);
        }
    }    
}
