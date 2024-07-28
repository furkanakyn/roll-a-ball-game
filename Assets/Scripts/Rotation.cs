using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector3 Fast;
    void Update()
    {
        transform.Rotate(Fast*0.01f);
    }
}
