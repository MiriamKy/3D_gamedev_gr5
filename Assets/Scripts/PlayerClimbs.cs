using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerClaiming : MonoBehaviour
{
    // betinglsene som skal for gjøer action
    public bool canClimb = false;
    public bool isClimbing = false;
    [SerializeField] public float clibingSpeed = 5f;

    [SerializeField] GameObject Player;

    //referanse til playerControll med PlayerMovement skrifte
    PlayerControls playerClimb;

    //public event Action OnKlatreAction;

    private void Awake()
    {
        playerClimb = new PlayerControls();

    }


    private void Start()
    {
       
       // playerClimb.OnKlatreAction.Klatre.performed += Climbing_Up;
        
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
