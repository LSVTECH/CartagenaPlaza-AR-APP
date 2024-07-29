using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstagramLink : MonoBehaviour
{
    public GameManager gameManager;

    public void abrirLink()
    {
        Application.OpenURL("https://www.instagram.com/ar/244681451970404");
    }
}
