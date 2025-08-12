using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CameraController : MonoBehaviour
{

    private CinemachineVirtualCamera vcam;
    [SerializeField] private Slider slider;

    public float maxCamZoom;
    public float minCamZoom;

    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        slider.value = 0.5f;
    }


    void Update()
    {
        if (slider.value > maxCamZoom & slider.value < minCamZoom)
        {
            vcam.m_Lens.OrthographicSize = slider.value * 50;
        }

    }
}
