using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float _movespeed = 10;
    Camera _maincamera;
    [SerializeField]
    Vector2 mousePosition;
    // Start is called before the first frame update
    void Start()
    {
        _maincamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = _maincamera.ScreenToWorldPoint(Input.mousePosition);
            transform.position = Vector2.MoveTowards(transform.position, mousePosition, _movespeed * Time.deltaTime);
        }
    }
}
