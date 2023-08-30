using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject Menu1;
    public GameObject Menu2;

    public void Back()
    {
        Menu2.SetActive(true);
        Menu1.SetActive(false);
    }
}
