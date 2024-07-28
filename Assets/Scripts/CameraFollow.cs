using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Ball;
    public Vector3 CameraOffset;
    void LateUpdate()
    {
        transform.position = CameraOffset + Ball.position;
    
    
    }
}
