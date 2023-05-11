using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] BallController ballController;
    [SerializeField] CameraController camController;
    private void Update()
    {
        camController.SetInputActive(Input.GetMouseButton(0));
    }
}
