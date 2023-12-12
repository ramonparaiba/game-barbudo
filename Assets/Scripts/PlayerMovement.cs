using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public float moveSpeed = 5f; // Velocidade de movimento do personagem

    private Rigidbody2D rb; // Referência ao Rigidbody2D do personagem

    public void Start()
    {
        // Obter o componente Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Ler o input horizontal e vertical (W, A, S, D ou setas)
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Chama o método Move para movimentar o personagem
        Move(moveHorizontal, moveVertical);
    }

    public void Move(float moveHorizontal, float moveVertical)
    {
        // Cria um vetor de movimento baseado nos inputs
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // Mover o personagem
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
