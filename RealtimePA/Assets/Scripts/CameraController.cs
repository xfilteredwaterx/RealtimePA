using UnityEngine;

/// <summary>
/// Steuert die Anzeige der einzelnen Menüs zum Konfigurieren
/// </summary>
public class CameraController : MonoBehaviour
{
    /// <summary>
    /// Referenz zum Animator, welche die Kamerasteuerung übernimmt
    /// </summary>
    public Animator animator;


    /// <summary>
    /// Menü für einen Index anzeigen
    /// Bereits geöffnetes Menü schließen
    /// </summary>
    /// <param name="index"></param>
    public void ChangeCamera(int index)
    { 
        // Kommunikation mit dem Animator herstellen
        animator.SetInteger("cameraIndex", index);
    }

}
