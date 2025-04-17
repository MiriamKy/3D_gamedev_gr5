using UnityEngine;
using UnityEngine.UI;

public class SeedCount : MonoBehaviour
{
    public Text climbSeedCount;
    public Text waterSeedCount;

    public GameManager CS;
    public GameManager WS;
    void Update()
    {

        climbSeedCount.text = GameManager.Instance.CurrentClimbSeeds().ToString();
        waterSeedCount.text = GameManager.Instance.CurrentWaterSeeds().ToString();
    }
}
