using UnityEngine;

public class Tank : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del tanque (ajusta según sea necesario)
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Obtener entrada horizontal del teclado
        float moveInput = Input.GetAxisRaw("Horizontal");

        // Calcular el vector de movimiento
        Vector3 moveDirection = new Vector3(moveInput, 0f, 0f);

        // Aplicar movimiento horizontal
        rb.velocity = moveDirection * moveSpeed;
    }
}
