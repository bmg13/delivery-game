using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject carToFollow;

    // Update the position of the camera compared to car in each frame
    void Update()
    {
        Vector3 zAxisDistanceFromCameraToCar = new Vector3(0,0,-10);
        transform.position = carToFollow.transform.position + zAxisDistanceFromCameraToCar;
    }
}
