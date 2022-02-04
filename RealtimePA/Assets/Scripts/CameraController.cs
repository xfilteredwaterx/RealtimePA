using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Steuert die Anzeige der einzelnen Menüs zum Konfigurieren
/// </summary>
public class CameraController : MonoBehaviour
{

    public int lastCam;
    public Toggle freeCamToggle;
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
        freeCamToggle.isOn = false;
    }

    public void ActivateFreeCam(Toggle toggle)
    {
        if (toggle.isOn == true)
        {
            lastCam = animator.GetInteger("cameraIndex");
            animator.SetInteger("cameraIndex", 3);
        }

        else
        {
            animator.SetInteger("cameraIndex", lastCam);   
        }
    }
}
