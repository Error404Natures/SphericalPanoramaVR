using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Portal : MonoBehaviour
{
    public Transform targetSphere; // ������� ������ ��������
    public Camera cameraPlayer; // ������ �� ������

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // ���������� ������ � ������ ����� �����
            cameraPlayer.transform.position = targetSphere.position;
        }
    }
}
