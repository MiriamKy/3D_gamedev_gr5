using UnityEngine;

public class playerAin : MonoBehaviour
{
    Animation animatior;
    [SerializeField] PlayerMovement player;

    private void Awake()
    {
        animatior = GetComponent<Animation>();
    }

    private void Update()
    {
        if (player.IsWaken() == true)
        {
            animatior.SetBool("IsWalking", true);
        }
        else
        {
            animatior.SetBool("IsWalkg", false);
        }
    }

}
