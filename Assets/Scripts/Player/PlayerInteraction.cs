using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [Header("Radio de Interacción")]
    public float interactionRange = 1.5f;
    public LayerMask interactableLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Buscar objeto más cercano en radio
            Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, interactionRange, interactableLayer);

            if (hits.Length > 0)
            {
                // Tomar el primer objeto que encuentre
                // o filtrar por prioridad
                IInteractable interactable = hits[0].GetComponent<IInteractable>();
                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Para visualizar el rango de interacción en la escena
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, interactionRange);
    }
}
