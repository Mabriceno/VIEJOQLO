using UnityEngine;

public class NPCTask : MonoBehaviour, IInteractable
{
    [Header("Estado de la Misión")]
    public bool needsTea = true;
    public bool missionCompleted = false;

    public void Interact()
    {
        if (!missionCompleted)
        {
            if (needsTea)
            {
                // Chequear si el jugador tiene la taza de té
                if (Inventory.Instance.HasItem("Teacup"))
                {
                    // Quitar la taza del inventario
                    Inventory.Instance.RemoveItem("Teacup");
                    needsTea = false;
                    missionCompleted = true;
                    Debug.Log("NPC: ¡Muchas gracias por la taza de té!");
                    // Recompensa o siguiente paso en la historia
                }
                else
                {
                    Debug.Log("NPC: Necesito una taza de té por favor...");
                }
            }
        }
        else
        {
            Debug.Log("NPC: Ya me has traído la taza de té, gracias.");
        }
    }
}
