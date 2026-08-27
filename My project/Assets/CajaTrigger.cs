using UnityEngine;

public class CajaTrigger : MonoBehaviour
{
    [Header("Sonido")]
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Marked"))
        {
            Debug.Log("¡Cubo correcto detectado!");
            if (audioSource != null)
            {
                audioSource.Play();
            }
        }
    }
}