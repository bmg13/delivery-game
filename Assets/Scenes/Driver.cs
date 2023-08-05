using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    private static string BOOSTER_TAG_NAME = "Booster";

    [SerializeField] private float turnSpeed = 1f;
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float slowSpeed = 0.05f;
    [SerializeField] private float boostSpeed = 0.03f;

    private void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed;// * Time.deltaTime; // Time.deltaTime allows to have framerate independency, regardless of PC (or mobile) running it
        float moveAmount = Input.GetAxis("Vertical") * speed; // * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount); // Added the minus to facilitate control
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        speed = slowSpeed;
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == BOOSTER_TAG_NAME){
            speed = speed + boostSpeed;
        }
    }
}
