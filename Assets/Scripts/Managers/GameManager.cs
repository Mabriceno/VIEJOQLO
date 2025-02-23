using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Parámetros de Cordura")]
    public float maxCordura = 100f;
    public float currentCordura;

    private void Awake()
    {
        // Patrón Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        currentCordura = maxCordura;
    }

    public void ModificarCordura(float cantidad)
    {
        currentCordura = Mathf.Clamp(currentCordura + cantidad, 0f, maxCordura);

        // Actualizar la UI
        UI.SanityBar sanityBar = FindObjectOfType<UI.SanityBar>();
        if (sanityBar != null)
        {
            sanityBar.ActualizarBarra(currentCordura / maxCordura);
        }

        // Si llega a 0, fin del juego
        if (currentCordura <= 0f)
        {
            Debug.Log("La cordura ha llegado a cero. Game Over.");
            // Implementar lógica de Game Over
        }
    }
}
