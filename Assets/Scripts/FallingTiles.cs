
using UnityEngine;

public class FallingTiles : MonoBehaviour
{
    public Vector3 velocity = Vector3.up;
    public float smooth = 2.0F;
    public float tiltAngle = 3.0F;
    void Update()
    {
        //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        //Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
       
    }
    
}

