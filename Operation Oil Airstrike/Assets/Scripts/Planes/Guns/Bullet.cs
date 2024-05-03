using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float Damage;
    private void Awake()
    {
        Destroy(gameObject, 1.5f);
    }
}
