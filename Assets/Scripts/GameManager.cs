using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Skal kun eksistere EN GameManager i spillet vårt
    // Den skal eksistere på tvers av scener
    // Ta med informasjon mellom scener
    // Tilgjengeliggjøre informasjon for mange GameObjects

    // Deklarerer singleten og bestemmer global tilgjengelighet og rettigheter til endring
    public static GameManager Instance { get; private set; }

    // Se nåværende liv spilleren har
    // Se maks liv spilleren kan ha

    // Variabler til de ulike typene frø
    private bool waterSeed = false;
    private bool climbSeed = false;
    private bool bounceSeed = false;

    private void Awake()
    {
        
        if(Instance == null)
        {
            Instance = this;
            // Gjøre gameObject tilgjengelig på tvers av scener
            DontDestroyOnLoad(gameObject);
        }
        else
        { 
            // Når det opprettes nytt GameObject, skal det gamle umiddelbart ødelegges
            Destroy(gameObject);
        }
    }

    // Returnerer variablene for frø for å gjøre dem tilgjengelige overalt
    public bool CurrentWaterSeeds()
    {
        return waterSeed;
    }

    public bool CurrentClimbSeeds()
    {
        return climbSeed;
    }

    public bool CurrentJumpSeeds()
    {
        return bounceSeed;
    }
}
