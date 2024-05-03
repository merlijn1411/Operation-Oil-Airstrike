using UnityEngine;

public class PlaneHealth : MonoBehaviour
{
    private PlaneStats _planeStats;
    void Start()
    {
        _planeStats = GetComponent<PlaneStats>();
    }

    
}
