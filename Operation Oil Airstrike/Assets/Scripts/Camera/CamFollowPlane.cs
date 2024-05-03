using UnityEngine;

public class CamFollowPlane : MonoBehaviour
{
    [SerializeField] private Transform planeAnchorPoint;
    private void LateUpdate()
    {
        transform.position = new Vector3(planeAnchorPoint.position.x + 0, planeAnchorPoint.position.y + 0, planeAnchorPoint.position.z - 10f);
    }
}
