using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector2 _direction;
    [SerializeField] float _speed;
    [SerializeField] Rigidbody2D _rb2d;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }
    private void Moving()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.y = Input.GetAxis("Vertical");
        _rb2d.MovePosition(_rb2d.position + _direction * _speed * Time.deltaTime);
    }
}
