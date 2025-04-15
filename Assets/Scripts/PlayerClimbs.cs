using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerClaiming : MonoBehaviour
{
    // betinglsene som skal for gjøer action
    public bool canClimb = false;
    public bool isclimbing = false;
    [SerializeField] public float clibingSpeed = 5f;

    [SerializeField] GameObject Player;

    //referanse til playerControll med PlayerMovement skrifte
    PlayerMovement playerAction;
   
    private void Awake()
    {
        playerAction = Player.GetComponent<PlayerMovement>();


    }


    private void Start()
    {
        //
        playerAction.OnInteractAction.Klatre.performed += Climbing_Up;
        Debug.Log()
    }


    private void Climbing_Up(InputAction.CallbackContext obj)
    {
        //aktiver actiom 

        
        if (canClimb == true)
        {
            //gå opp 

        


        }
        
       

        
    }
    
    //sopp når er oppe (canClimb)






}
