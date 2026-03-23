using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform playerTransform;

    private float fixedY;
    void Start()
    {
        fixedY = transform.position.y;
    }


    void LateUpdate()
    {
        transform.position = new Vector3(playerTransform.position.x, fixedY,transform.position.z);
    }
}
