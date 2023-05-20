using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public static InventorySystem instance;
    public List<SkinScriptable> skins;
    private void Awake()
    {
        instance = this;
    }

    public void Add(SkinScriptable skin)
    {
        skins.Add(skin);
    }


}
