using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage;
    [SerializeField] private float timer;
    private void Awake()
    {
        Destroy(gameObject, timer);
    }
    
}
