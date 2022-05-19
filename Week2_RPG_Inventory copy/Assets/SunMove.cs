using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMove : MonoBehaviour
{
    public float speed = 3f;
    private bool movingRight = true;
    void FixedUpdate(){
        if(movingRight){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >=5){
                movingRight = false;
            }
        } else {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if(transform.position.x <= -5){
                movingRight = true;
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
