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
    private int waterSeed = 0;
    private int climbSeed = 0;

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

    // Disse metodene legger til frø i climbSeed osv.
    // Husk at det ikke skjer før du kaller metodene/
    public void IncreaseClimbSeed(int amount)
    {
        climbSeed += amount;
    }

    public void IncreaseWaterSeed(int amount)
    {
        waterSeed += amount;
    }

    // Returnerer variablene for frø for å gjøre dem tilgjengelige overalt
    public int CurrentWaterSeeds()
    {
        return waterSeed;
    }

    public int CurrentClimbSeeds()
    {
        return climbSeed;
    }
}
