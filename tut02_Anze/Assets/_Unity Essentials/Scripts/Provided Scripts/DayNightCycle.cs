using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Duracion del dia en segundos (tiempo real)")]
    [Tooltip("Cantidad de segundos reales que tarda un dia completo en pasar.")]
    public float dayDurationInSeconds = 120f; // Valor por defecto = 2 minutos

    private float rotationSpeed;

    void Start()
    {
        // 360 grados por el tiempo que dura un día
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rota la luz alrededor del eje X (como el sol subiendo y bajando)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}
