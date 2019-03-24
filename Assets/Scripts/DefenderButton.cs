using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DefenderButton : MonoBehaviour
{
    [SerializeField] Defender defenderPrefab;

    private void Start()
    {
        LabelButtonWithCost();
    }

    private void LabelButtonWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if(!costText)
        {
            //Debug.LogError(name + " has np text, please add some cost.");
        }
        else
        {
            costText.text = defenderPrefab.GetDefenderCost().ToString();
        }
    }

    private void OnMouseDown()
    {
        
        FindObjectOfType<DefSpawner>().ChooseDefender(defenderPrefab);

        var buttons = FindObjectsOfType<DefenderButton>();
        foreach (DefenderButton button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(53, 53, 53, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
    }

}
