using UnityEngine;

public class DestinationRoute : MonoBehaviour
{
    [SerializeField] private Transform beginPoint;
    [SerializeField] private Transform endPoint;
    
    [SerializeField] private GameObject plane;

    [SerializeField] private Vector3 v3;
    [SerializeField] float planeSpeed = 2.0f;
    void Start()
    {
        plane.transform.position = beginPoint.transform.position;
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

        plane.transform.position += v3 * (planeSpeed * Time.deltaTime);
    }

    private void DestinationChecker()
    {
        float distance = (endPoint.position - plane.transform.position).magnitude;
        if (distance < (v3 * (planeSpeed * Time.deltaTime)).magnitude)
        {
            plane.transform.position = endPoint.position;
            planeSpeed = 0f;
        }
    }
    
    
}
