using UnityEngine;
using UnityEngine.InputSystem;

public class player_roter : MonoBehaviour
{
    [SerializeField] public float rotationSpeed = 1f;
    void Update()
    {

     //   Vector3 movementVector = playerInput.Player.Move.ReadValue<Vector3>();

     //   transform.forward = Vector3.Slerp(transform.forward, movementVector, rotationSpeed * Time.deltaTime);

    }
}
