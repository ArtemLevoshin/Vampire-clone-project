using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform player;
    public float moveSpeed = 10;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.position = new Vector3(player.position.x, player.position.y, player.position.z - 10);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3 
        {
            x = player.position.x,
            y = player.position.y,
            z = player.position.z - 10
        };
        Vector3 pos = Vector3.Lerp(transform.position, target, moveSpeed * Time.deltaTime);
        transform.position = pos;
       
    }
}
