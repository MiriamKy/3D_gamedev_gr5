using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Definerer farten til spilleren

    public float speed = 5f;

    // Vektorer for bevegelsesretninger
    Vector3 forward;
    Vector3 right;

    // Setter forward til å være kameraets fremoverretning, men ignorerer høyden (y-aksen)
    // Normaliserer vektoren for jevn bevegelse
    private void Start()
    {
        forward = Camera.main.transform.forward;
        forward.y = 0;
        forward = Vector3.Normalize(forward);
        
        // Beregner en høyre-vektor ved å rotere forward 90 grader rundt Y-aksen
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;
    }


    // Sjekker om en tast trykkes og kaller Move-funksjonen hvis ja
    private void Update()
    {
        if (Input.anyKey)
        {
            Move();
        }
    }

    // Metode for å håndtere spillerens bevegelse
    private void Move ()
    {
        // Leser input fra tastaturet for horisontal (A/D piltast) og vertikal (W/S piltast) bevegelse
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Vector3 rightMovement = right * speed * Time.deltaTime * Input.GetAxis("Horizontal");

        Vector3 upMovement = forward * speed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        // Roterer spilleren i bevegelsesretningen
        transform.forward = heading;

        // Flytter spilleren i riktig retning
        transform.position += rightMovement;
        transform.position += upMovement;
    }


}
