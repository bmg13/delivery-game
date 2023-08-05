using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    private static string PACKAGE_TAG_NAME = "Package";
    private static string CUSTOMER_TAG_NAME = "Customer";

    [SerializeField] Color32 carOriginalColour = new Color32(255, 255, 255, 255);
    [SerializeField] Color32 carWithPackageColour = new Color32(255, 255, 177, 255);

    private bool carHasPackage;
    private float destroyObjectDelay = 0.1f;

    SpriteRenderer spriteRenderer;
    
    private void Start()
    {
        this.carHasPackage = false;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("impact!");
    }
    
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == PACKAGE_TAG_NAME && !carHasPackage){
            Debug.Log("Package picked up");
            Destroy(other.gameObject, destroyObjectDelay);
            carHasPackage = true;
            spriteRenderer.color = carWithPackageColour;
        } else if (other.tag == CUSTOMER_TAG_NAME && carHasPackage){
            Debug.Log("Package delivered");
            carHasPackage = false;
            spriteRenderer.color = carOriginalColour;
        }
    }
}
