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
        // Setter rigid body på spilleren
        rb = GetComponent<Rigidbody>();
    }

    // Når spillet kjører skal vi lytte etter inputs og sette dem i variabler

    private void Update()
    {
        // float xMove = (her trenger vi å lytte etter inputs fra playerInputActions og sette verdien)
        // float yMove = (her trenger vi å lytte etter inputs fra playerInputActions og sette verdien)

    }

    // Når variablene får verdier (via input) skal spilleren flytte seg basert på disse
    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    // Når input slutter skal spilleren slutte å flytte på seg

    private void OnDisable()
    {
        playerInputActions.Disable();
    }

}
