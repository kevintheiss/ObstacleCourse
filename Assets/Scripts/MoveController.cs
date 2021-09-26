using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with the WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }

    void MovePlayer()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zMove = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xMove, 0f, zMove);
    }
}
