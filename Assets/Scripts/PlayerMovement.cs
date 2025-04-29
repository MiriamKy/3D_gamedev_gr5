using System;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls playerInput;

    // Definerer farten til spilleren
    [SerializeField] public float speed = 5f;
    [SerializeField] public float rotationSpeed = 1f;


    // staret med står i ro 
    private bool isWalking = false;



    public event Action OnInteractAction;

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
    void Start()
    {
        //Setter opp en lytter til et event
        playerInput.Player.Interact.performed += Interact_performed;
        //Debug.Log(GameManager.Instance.CurrentWaterSeeds());
    }

    private void Interact_performed(InputAction.CallbackContext obj)
    {
        // Trigger den Action som ble laget legner opp og sjekker om noen lytter
        OnInteractAction?.Invoke();
    }


    // Sjekker om en tast trykkes og kaller Move-funksjonen hvis ja
    void Update()
    {
        // Henter input fra bruker, og konverterer dcen til 3 dimensjoner
         Vector3 movementVector = playerInput.Player.Move.ReadValue<Vector3>();
        if (movementVector.magnitude > rotationSpeed)

        //for at careter få animasjon når den går
        if (movementVector == Vector3.zero)
            {
                isWalking = false;
            }
            else
            {
                isWalking = true;
            }




        // Kobler på transform-komponentet for å kontrollere posisjonen til spilleren via input
        // Foreløpig raskeste løsning (kan bli behov for å legge til fysikk senere)
        transform.Translate(movementVector * speed * Time.deltaTime);

        //rotasjon cartae
        transform.rotation = Quaternion.Euler(movementVector);

        //transform.rotation = transform.rotation.Euler( movementVector);


    }

    public bool IsWalking()
    {
        return isWalking;

    }


}
