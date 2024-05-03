using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    private Plane _planeStats;
    
    private float _horizontal;
    private float _vertical;

    private Rigidbody2D _body;

    private void Start()
    {
        _planeStats = GetComponent<Plane>();
        _body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical"); 
    }

    private void FixedUpdate()
    {
        _body.velocity = new Vector2(_horizontal * _planeStats.steerSpeed, _vertical * _planeStats.steerSpeed);
    }
}
