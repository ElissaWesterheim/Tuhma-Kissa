using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform PlayerCat;
    private void Update()
    {
        transform.position = new Vector3(PlayerCat.position.x, PlayerCat.position.y, transform.position.z);
    }
}
