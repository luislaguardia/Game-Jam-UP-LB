using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// should crate "CameraFollow" script inside the Main Camera then drag mo yung player object for the camera to f,aollow
public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public float yOffset = 1f;
    public Transform target;
    //yOffset for height adjustments yan

    void Update()
    {
        Vector3 newPosition = new Vector3(target.position.x, target.position.y + yOffset, -10f);
        transform.position = Vector3.Slerp(transform.position, newPosition, FollowSpeed*Time.deltaTime);
    }
}
