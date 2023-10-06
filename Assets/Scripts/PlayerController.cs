using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 // Start is called before the first frame update
 void Start()
 {
 
 }
 private float speed = 20.0f;

 private float turnSpeed = 45.0f;

 private float horizontalInput;

 private float forwardInput;

 public bool hasCollectible;

 private void OnTriggerEnter(Collider other) {

 if(other.CompareTag("Collectible")) 
 {
 GameManager.playerScore += 10;
 Destroy(other.gameObject);
 }
 }

 // Update is called once per frame
 void Update()
 {
 horizontalInput = Input.GetAxis("Horizontal");
 forwardInput = Input.GetAxis("Vertical");


 transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
 
 transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
 }
}