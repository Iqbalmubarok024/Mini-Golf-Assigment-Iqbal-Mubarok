using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField] CinemachineFreeLook CMFrelook; 
    public void SetInputActive(bool value)
    {
        if(value)
        {
            CMFrelook.m_XAxis.m_InputAxisName = "Mouse X";
            CMFrelook.m_YAxis.m_InputAxisName = "Mouse Y";
        }
        else
        {
            CMFrelook.m_XAxis.m_InputAxisName = "";
            CMFrelook.m_YAxis.m_InputAxisName = "";

            CMFrelook.m_XAxis.m_InputAxisValue = 0;
            CMFrelook.m_YAxis.m_InputAxisValue = 0;
        }
    }
}
