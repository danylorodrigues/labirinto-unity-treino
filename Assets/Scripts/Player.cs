using Unity.Mathematics;
using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rid;
    public Transform cam;
    public float speed = 10;
    
    bool esquerda, frente, back, direita;

    void Update()
    {
        HandleInput();
    }

    void FixedUpdate()
    {
        HandleMoviment();
    }

    void HandleMoviment()
    {
        Quaternion dir = Quaternion.Euler(0f, cam.rotation.eulerAngles.y,0f);

        if (esquerda)
        {
            rid.AddForce(dir * Vector3.left * speed);
            esquerda = false;
        }
          if (direita)
        {
            rid.AddForce(dir * Vector3.right * speed);
            direita = false;
        }
          if (frente)
        {
            rid.AddForce(dir * Vector3.forward * speed);
            frente = false;
        }
          if (back)
        {
            rid.AddForce(dir * Vector3.back * speed);
            back = false;
        }
    }

    void HandleInput()
    {

        if (Input.GetKey(KeyCode.A))
        {
            esquerda = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direita = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            back = true;
        }
        if (Input.GetKey(KeyCode.W))
        {
            frente = true;
        }


    }

}
