using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
   public float speed;
   private Transform target;
   public int davide;
 // Use this for initialization
 void Start () {
     target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
 	}
 
 // Update is called once per frame
 void Update () {
     
     transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
	 transform.LookAt(target);
	 if(davide == 0){
	 	
		transform.Rotate(0.0f, 85.0f, 0.0f);
		
	 }
	 
    // Update is called once per frame
    
 }
}