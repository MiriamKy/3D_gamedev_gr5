using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Definerer farten til spilleren

    [SerializeField] public float speed = 5f;

    private PlayerControls playerInput;

    // Vektorer for bevegelsesretninger
    Vector3 forward;
    Vector3 right;

    void Awake()
    {
        playerInput = new PlayerControls();

    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }
    public void OnMove()
    {
        
    }

    // Setter forward til å være kameraets fremoverretning, men ignorerer høyden (y-aksen)
    // Normaliserer vektoren for jevn bevegelse
    void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        
        // Beregner en høyre-vektor ved å rotere forward 90 grader rundt Y-aksen
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }


    // Sjekker om en tast trykkes og kaller Move-funksjonen hvis ja
    void Update()
    {
        // Henter input fra bruker, og konverterer dcen til 3 dimensjoner
        Vector2 xyMove = playerInput.Player.Move.ReadValue<Vector2>();
        Vector3 movementVector = new Vector3(xyMove.x, 0, xyMove.y);

        // Kobler på transform-komponentet for å kontrollere posisjonen til spilleren via input
        // Foreløpig raskeste løsning (kan bli behov for å legge til fysikk senere)
        transform.Translate(movementVector * speed * Time.deltaTime);

    }


}
