using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject InfoPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InfoPanel.SetActive(true);

            Debug.Log("Скрипт сработал");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            InfoPanel.SetActive(false);
            Debug.Log("Скрипт сработал");
        }
    }
}
