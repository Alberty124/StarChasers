using UnityEngine;

public class EnterSpaceship : MonoBehaviour
{
    public GameObject spaceship;
    private bool isActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActive = true;
            // Activate the spaceship or perform any necessary actions.
            spaceship.SetActive(true);
        }
    }

    private void Update()
    {
        if (isActive && Input.GetKeyDown(KeyCode.F))
        {
            // Perform actions to enter the spaceship (e.g., disable player controls, camera change).
            // For instance, you can deactivate the player's GameObject to signify the player entering the spaceship.
            other.gameObject.SetActive(false);

            // Activate spaceship controls or any logic specific to spaceship behavior.
            spaceship.GetComponent<SpaceshipController>().enabled = true;
        }
    }
}
