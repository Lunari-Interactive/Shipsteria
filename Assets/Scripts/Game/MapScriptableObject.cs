using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "New Map", menuName = "CreateNewMap")]
public class MapScriptableObject : ScriptableObject
{
    public int MapIndex;

    public Image MapImage;
    public string MapName;
    public Object Map;
}
