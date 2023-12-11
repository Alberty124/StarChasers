using UnityEngine;

public class SpaceshipTriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpaceshipController spaceship = transform.parent.GetComponent<SpaceshipController>();
            if (spaceship != null)
            {
                spaceship.EnterSpaceship();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Add logic if needed when the player exits the trigger zone.
    }
}
