using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowCamera : MonoBehaviour
{
    // Referanse til spilleren som kameraet skal følge
    public GameObject player;


    // Setter kameraets posisjon til å følge spilleren
    void Update()
    {
        transform.position = player.transform.position + new Vector3(2.1f, 5.38f, 10.69f);
    }
}
