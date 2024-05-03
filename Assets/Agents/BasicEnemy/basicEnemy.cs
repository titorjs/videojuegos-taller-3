using System.Collections;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    private int paso = 0;
    private float cambio = 1;

    private void Start()
    {
        // Llama al método CambiarPosicion cada segundo, después de 0 segundos de espera
        InvokeRepeating("CambiarPosicion", 0f, 2f);
    }

    private void CambiarPosicion()
    {
        switch (paso)
        {
            case 0:
                transform.position += new Vector3(0, 0, cambio);
                break;
            case 1:
                transform.position += new Vector3(cambio, 0, 0);
                break;
            case 2:
                transform.position += new Vector3(0, 0, -cambio);
                break;
            case 3:
                transform.position += new Vector3(-cambio, 0, 0);
                break;
            default:
                Debug.LogError("¡Error en el paso!");
                break;
        }

        paso = (paso + 1) % 4; // Incrementa el paso y asegura que permanezca en el rango 0-3
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet")) 
        { 
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}