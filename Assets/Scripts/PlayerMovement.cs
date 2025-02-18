using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Definere fart og fortelle at det finnes rigid body
    private float speed = 10f;
    Rigidbody rb;
    
    // Deklarere variabel som er knyttet til PlayerControls (??)
    private PlayerControls playerInputActions;

    private void Start()
    {
        // Setter rigid body p� spilleren
        rb = GetComponent<Rigidbody>();
    }

    // N�r spillet kj�rer skal vi lytte etter inputs og sette dem i variabler

    private void Update()
    {
        // float xMove = (her trenger vi � lytte etter inputs fra playerInputActions og sette verdien)
        // float yMove = (her trenger vi � lytte etter inputs fra playerInputActions og sette verdien)

    }

    // N�r variablene f�r verdier (via input) skal spilleren flytte seg basert p� disse
    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    // N�r input slutter skal spilleren slutte � flytte p� seg

    private void OnDisable()
    {
        playerInputActions.Disable();
    }

}
