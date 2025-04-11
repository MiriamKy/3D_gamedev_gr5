using UnityEngine;
using UnityEngine.UIElements;

public class playerAinmasjon : MonoBehaviour
{
    
    [SerializeField] PlayerMovement player;

    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
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
