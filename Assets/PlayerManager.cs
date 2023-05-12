using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] BallController ballController;
    [SerializeField] CameraController camController;
    private void Update()
    {
        var inputActive = Input.GetMouseButton(0) 
            && ballController.IsMove() == false 
            && ballController.ShootingMode == false;
            
        camController.SetInputActive(inputActive);
    }
}
