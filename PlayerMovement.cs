using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
{
    public Vector2 target;
    public float speed = 2f;


    void Awake()
    {
        DontDestroyOnLoad(this);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed);
        }

    }


}
