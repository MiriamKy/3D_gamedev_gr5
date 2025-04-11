using UnityEngine;

public class SeedDetect : MonoBehaviour
{
    // Variabler som skal fortelle oss om vi står i nærheten av et frø
    [SerializeField] private bool detectClimbSeed = false;
    [SerializeField] private bool detectWaterSeed = false;

    private PlayerMovement input;

    private void Start()
    {
        input = GetComponent<PlayerMovement>();
        input.OnInteractAction += Input_OnInteractAction;
    }

    private void Input_OnInteractAction()
    {
        if(detectClimbSeed)
        {
            GameManager.Instance.IncreaseClimbSeed(1);
            //Destroye seed-objektet
            //Husk å hente verdien/antallet der du trenger det, ved hjelp av denne linjen:
            //GameManager.Instance.CurrentClimbSeeds();
        } else
        {
            Debug.Log("Ikke legg til");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Hvis spilleren vår går inn i triggeren, sett pickSeed til true
        if (other.CompareTag("ClimbSeed")) //"ClimbSeed" er navnet på taggen, husk å tagge
        {
            detectClimbSeed = true;
            //Få opp et symbol som sier at du kan plukke (canvas)
            Debug.Log("Climb seed = " + detectClimbSeed);
        }
        if (other.CompareTag("WaterSeed")) //"WaterSeed" er navnet på taggen, husk å tagge
        {
            //Få opp et symbol som sier at du kan plukke (canvas)
            detectWaterSeed = true;
            Debug.Log("Water Seed = " + detectWaterSeed);
        }
    }

    // Setter boolen til false når spilleren går ut av collideren
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ClimbSeed"))
        {
            detectClimbSeed = false;
            Debug.Log("Climb seed = " + detectClimbSeed);
        }
        if (other.CompareTag("WaterSeed"))
        {
            detectWaterSeed = false;
            Debug.Log("Water Seed = " + detectWaterSeed);
        }
    }

    // Gjøre informasjonen i variabelene tilgjengelig for andre scripts
    public bool DetectClimbSeed()
    {
        return detectClimbSeed;
    }
    public bool DetectWaterSeed()
    {
        return detectWaterSeed;
    }


}
