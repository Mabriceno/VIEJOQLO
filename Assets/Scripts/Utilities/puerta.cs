using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    public string sceneToLoad; // Asignar en el Inspector

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // o como identifiques al player
        {
            SceneController.Instance.LoadScene(sceneToLoad);
        }
    }
}
