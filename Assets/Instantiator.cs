using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    public GameObject[] candy;
    void Start()
    {
        StartCoroutine(spawn());

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position ;
        pos.x = Random.Range(-7.272857f,7.322584f);
        transform.position = pos;        
    }
    IEnumerator spawn(){
    while(true){
     GameObject newObject = Instantiate(candy[Random.Range(0,candy.Length)],transform.position, Quaternion.identity);
     newObject.transform.localScale = new Vector3(0.375f, 0.375f, newObject.transform.localScale.z); 
     newObject.AddComponent<Rigidbody2D>();
     newObject.AddComponent<CircleCollider2D>();
     
     newObject.tag = "Candy";
     int wait = Random.Range(3,6);
     Debug.Log(wait);
     yield return new WaitForSeconds(wait);
    }
}
}