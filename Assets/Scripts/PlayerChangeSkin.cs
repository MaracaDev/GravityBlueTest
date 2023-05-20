using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChangeSkin : MonoBehaviour
{
    public SkinScriptable actualSkin;
    public GameObject skinHead, skinBody;

    public SkinScriptable skinChoosed;


    public void Wear(SkinScriptable skin)
    {
        skin = actualSkin;

        switch (skin.skinType)
        {
            case "Top":
                skinHead.GetComponent<SpriteRenderer>().sprite = skin.skinArt;
                break;

            case "Body":
                skinBody.GetComponent<SpriteRenderer>().sprite = skin.skinArt;
                break;
        }
    }

    private void Start()
    {
        Wear(actualSkin);
    }
}
