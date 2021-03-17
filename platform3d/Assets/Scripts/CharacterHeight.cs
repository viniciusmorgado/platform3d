using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHeight : MonoBehaviour
{
    public Transform character;
    Text TextOfInterface;

    // Start is called before the first frame update
    void Start()
    {
        TextOfInterface = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(character.position.y);
        
        // This doenst work .-.
        /*var CharacterPositionInY = Convert.ToInt32(TextOfInterface);

        if(CharacterPositionInY < 0)
        {
            TextOfInterface.text = "You die";
        }*/
        TextOfInterface.text = Mathf.RoundToInt(character.position.y).ToString();
    }
}
