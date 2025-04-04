using UnityEngine;
using UnityEngine.UIElements;

public class playerAin : MonoBehaviour
{
    
    [SerializeField] PlayerMovement player;
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (player.isWalking() == true)
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalkg", false);
        }
    }

}
