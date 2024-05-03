using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float timer;
    private void Awake()
    {
        Destroy(gameObject, timer);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        IDamageable damageable = collision.gameObject.GetComponent();
 
        if(damageable != null)
        {
            damageable.TakeDamage(5);
        }
    }
}
