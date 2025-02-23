using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movimiento")]
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Leer input
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        movement = new Vector2(moveX, moveY);

        // Aquí puedes implementar lógica de animaciones
        // Ej: actualizar animaciones según direction
    }

    private void FixedUpdate()
    {
        // Movimiento
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
