using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    private Vector3 smallFoot, bigFoot;
    private bool isBigFoot;

    private void Start()
    {
        smallFoot = new Vector3 (0.25f, 0.25f, 0.25f);
        bigFoot = new Vector3(1f,1f,1f);
        isBigFoot = true;

    }


    private void OnMouseDown()
    {
        transform.localScale = isBigFoot ? smallFoot : bigFoot;
        isBigFoot = !isBigFoot;
    }
}
