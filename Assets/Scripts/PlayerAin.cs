using UnityEngine;

public class PlayerAin : MonoBehaviour
{
    [SerializeField] PlayerMovement player;

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        GetComponent<Animator>().applyRootMotion = false;
    }

    private void Update()
    {
        if (player.IsWalking() == true)
        {
            animator.SetBool("isWalking", true);
        }
        else
        {
            animator.SetBool("isWalking", false);
        }


    }
    
}
