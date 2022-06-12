using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float maxSpeed = 20f;
    float HAccelration = 30;
    public static int score;
    void Start()
    {
        score = 0;
    }
    void Update()
    {
        Vector3 pos = transform.position;
        float Hvalue = Input.GetAxis("Horizontal");
        float velocity = (Hvalue*HAccelration*Time.deltaTime);
        if(Hvalue == 0){
            velocity = Mathf.Lerp(velocity,0,0.1f);
        }
        transform.Translate(velocity,0,0);
        pos.x = Mathf.Clamp(transform.position.x,-7.272857f,7.322584f);
        transform.position = pos;
    }
    private void OnCollisionEnter2D(Collision2D other) {
        
        if(other.gameObject.tag == "Candy"){
            Destroy(other.gameObject);
            score++;
         //   Debug.Log(score);
        }
    }
}
