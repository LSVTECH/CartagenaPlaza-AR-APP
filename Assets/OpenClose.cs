using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenClose : MonoBehaviour
{
    public Animator BotonesInteractivos;

    public void Interruptor()
    {
        BotonesInteractivos.SetBool(
            "Open/Close",
            value: !BotonesInteractivos.GetBool("Open/Close")
        );
    }
}
