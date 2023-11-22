using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            text.text = "Zmieniony tekst";
            text.color = Color.blue;
            text.fontSize = 35;
            text.fontStyle = FontStyles.Bold;
        }
    }
}
