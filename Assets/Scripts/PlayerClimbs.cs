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

        isClimbing = true;
        

        Vector3 OppVector = new Vector3(0, 1, 0);


        if (canClimb == true)
        {
            //gå opp 
        
        
        }
        //sopp når er oppe (canClimb)

    }
    
    






}
