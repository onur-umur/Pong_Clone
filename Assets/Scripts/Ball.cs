using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed =30;
    float hitFactor(Vector2 ballPos,Vector2 racketPos,float racketHeight){
        return(ballPos.y - racketPos.y);
    }
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed ;
    }
    public void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name =="RacketLeft")
        {
            float y = hitFactor(transform.position,col.transform.position,col.collider.bounds.size.y);
            Vector2 dir = new Vector2 (1,y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir*speed ;
        }

        if (col.gameObject.name=="RacketLeft")
        {
            float y = hitFactor(transform.position,col.transform.position,col.collider.bounds.size.y);
            Vector2 dir = new Vector2(-1,y).normalized;
            GetComponent<Rigidbody2D>().velocity = dir*speed ;
        }
    }

}
