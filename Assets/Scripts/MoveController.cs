using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMove, 0f, zMove);
    }
}
