using UnityEngine;

public class EnterSpaceship : MonoBehaviour
{
    public GameObject spaceship; 
    public KeyCode enterKey = KeyCode.F;

    private bool canEnter = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canEnter = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canEnter = false;
        }
    }

    private void Update()
    {
        if (canEnter && Input.GetKeyDown(enterKey))
        {
            spaceship.GetComponent<SpaceshipController>().EnterSpaceship();
        }
    }
}
