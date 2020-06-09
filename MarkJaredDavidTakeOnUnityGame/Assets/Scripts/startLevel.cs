using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startLevel : MonoBehaviour
{
    public void changeScreen(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
