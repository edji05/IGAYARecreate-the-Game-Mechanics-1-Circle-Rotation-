using UnityEngine;

public class SunClick : MonoBehaviour
{
    private OrbitController orbitController;

    void Start()
    {
        // get the OrbitController from parent (CenterPoint)
        orbitController = GetComponentInParent<OrbitController>();
    }

    void OnMouseDown()
    {
        Debug.Log("Sun clicked");
        if (orbitController != null)
            orbitController.ToggleDirection();
    }
}