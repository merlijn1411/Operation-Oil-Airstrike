using UnityEngine;

public class MgGun : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform _gunpPosn;

    [SerializeField] private float _fireSpeed = 10f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }
    }

    private void FireBullet()
    {
        var bullet = Instantiate(bulletPrefab, _gunpPosn.position, _gunpPosn.rotation);
        bullet.GetComponent<Rigidbody2D>().velocity = _gunpPosn.up *  _fireSpeed;
    }
}
