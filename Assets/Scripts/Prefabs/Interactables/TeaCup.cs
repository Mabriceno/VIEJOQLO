using UnityEngine;

public class Teacup : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        // Agregar al inventario
        Inventory.Instance.AddItem("Teacup");
        // Destruir el objeto en la escena
        Destroy(gameObject);
    }
}
