using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerClaiming : MonoBehaviour
{
    // betinglsene som skal for gjøer action
    public bool canClimb = false;
    public bool isClimbing = false;
    [SerializeField] public float clibingSpeed = 5f;

   

    //referanse til playerControll med PlayerMovement skrifte
    PlayerControls playerClimb;
    
    

    public event Action OnInteractAction;

    private void Awake()
    {
        playerClimb = new PlayerControls();

    }
    private void OnEnable()
    {
        playerClimb.Enable();

    }
    private void OnDisable()
    {
        playerClimb.Disable();
    }


    private void Start()
    {
       
      playerClimb.Player.Klatre.performed += Climbing_Up;
       Debug.Log("klare sktifte");
        
    }


    private void Climbing_Up(InputAction.CallbackContext obj)
    {
        //aktiver actiom 
        Debug.Log("klarter");
        OnInteractAction?.Invoke();

        

    }

    private void Update()
    {
        //isClimbing = true;



        //Vector3 inputVector = new Vector3(0, 2, 0);
        // Vector3 OppVector = 
        
        //Rotate(0, rotationSpeed, 0);


        if (canClimb == true)
        {
            //gå opp 


        }
        //sopp når er oppe (canClimb)
    }

    //rtur canClimb








}
