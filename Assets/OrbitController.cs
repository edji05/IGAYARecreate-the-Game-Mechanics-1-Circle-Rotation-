using UnityEngine;

public class OrbitController : MonoBehaviour
{
    public float orbitSpeed = 50f;
    private bool clockwise = true;

    void Update()
    {
        float dir = clockwise ? 1f : -1f;
        // rotate the center — child (Sun) will orbit
        transform.Rotate(0f, 0f, orbitSpeed * dir * Time.deltaTime);

        // optional: toggle with Space key
        if (Input.GetKeyDown(KeyCode.Space))
            ToggleDirection();
    }

    public void ToggleDirection()
    {
        clockwise = !clockwise;
    }
}
