using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{
    public void OnMouseDown()
    {
        Handheld.Vibrate();
    }
}
