using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float timer;
    private void Awake()
    {
        Destroy(gameObject, timer);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        IDamageable damageable = other.gameObject.GetComponent<IDamageable>();
 
        if(damageable != null)
        {
            damageable.TakeDamage(damage);
        }
    }
}
