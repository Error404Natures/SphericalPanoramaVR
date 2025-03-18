using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Portal : MonoBehaviour
{
    public Transform targetSphere; // Позиция второй панорамы
    public Camera cameraPlayer; // Ссылка на камеру

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Перемещаем камеру к центру новой сферы
            cameraPlayer.transform.position = targetSphere.position;
        }
    }
}
