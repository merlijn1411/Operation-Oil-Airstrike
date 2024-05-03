using UnityEngine;

public class PlaneHealth : MonoBehaviour, IDamageable
{
    private PlaneStats _planeStats;
    void Start()
    {
        _planeStats = GetComponent<PlaneStats>();
    }

    public void TakeDamage(float damage)
    {
        _planeStats.health -= damage;
        Debug.Log(_planeStats.health + "Health Updated");
    }
}


