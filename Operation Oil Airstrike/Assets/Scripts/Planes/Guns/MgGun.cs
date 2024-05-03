using UnityEngine;

public class MgGun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform gunpPos;

    [SerializeField] private float fireSpeed = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        var bullet = Instantiate(bulletPrefab, gunpPos.position, gunpPos.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = gunpPos.up *  fireSpeed;
    }
}
