using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float maxSpeed = 20f;
    float HAccelration = 30;
    public int score;

    Vector2 velocity = Vector2.zero;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position ;

        float Hvalue = Input.GetAxis("Horizontal");
        float velocity = Hvalue*HAccelration*Time.deltaTime;
        if(Hvalue == 0){
            velocity = Mathf.Lerp(velocity,0,0.1f);
        }
        velocity = Mathf.Clamp(velocity,-maxSpeed,maxSpeed);
        transform.Translate(velocity,0,0);
        pos.x = Mathf.Clamp(transform.position.x,-7.272857f,7.322584f);
        //Debug.Log(velocity); -7.272857 , 7.322584
        transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Candy"){
            Destroy(other.gameObject);
            score++;
        }
    }
}
