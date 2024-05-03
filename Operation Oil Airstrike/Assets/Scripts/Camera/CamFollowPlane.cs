using UnityEngine;

public class CamFollowPlane : MonoBehaviour
{
    [SerializeField] private Transform plane;
    private void LateUpdate()
    {
        transform.position = new Vector3(plane.position.x + 0, plane.position.y + 0, plane.position.z - 10f);
    }
}
