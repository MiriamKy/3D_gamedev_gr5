using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerClaiming : MonoBehaviour
{
    // betinglsene som skal for gjøer aksen 
    public bool canClimb = false;
    public bool isclimbing = false;


    //referanse til playerControll InputSystem 
    public InputActionReference klatre;

    [SerializeField] private PlayerMovement Player;



    // private PlayerControls playercliming;

    [SerializeField] public float cliingSpeed = 5f;

    private void Start()
    {
        Player.Klatre
    }


    private void Update()
    {
        //aktiver actiom 
        if (canClimb == true)
        {
            //gå opp 

        


        }
        
       

        
    }
    
    //sopp når er oppe (canClimb)






}
