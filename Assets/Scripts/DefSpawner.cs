using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefSpawner : MonoBehaviour
{
    [SerializeField] GameObject defender;

    private void OnMouseDown()
    {
        Debug.Log("click");
        SpawnDefender();
    }
    
    private void SpawnDefender()
    {
        GameObject newDefender = Instantiate(defender, transform.position, Quaternion.identity) as GameObject;
    }
}
