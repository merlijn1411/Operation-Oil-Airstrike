using UnityEngine;

public class DestinationRoute : MonoBehaviour
{
    [SerializeField] private Transform beginPoint;
    [SerializeField] private Transform endPoint;
    
    [SerializeField] private Transform planeAnchorPoint;

    [SerializeField] private Vector3 v3;
    [SerializeField] float camSpeed = 2f;
    void Start()
    {
        planeAnchorPoint.position = beginPoint.position;
    }
    
    void Update()
    {
        GoToDestination();
        DestinationChecker();
    }

    private void GoToDestination()
    {
        v3 = endPoint.position - beginPoint.position;
        v3 = v3.normalized;

        planeAnchorPoint.position += v3 * (camSpeed * Time.deltaTime);
    }

    private void DestinationChecker()
    {
        float distance = (endPoint.position - planeAnchorPoint.position).magnitude;
        if (distance < (v3 * (camSpeed * Time.deltaTime)).magnitude)
        {
            planeAnchorPoint.position = endPoint.position;
            camSpeed = 0f;
        }
    }
    
    
}
