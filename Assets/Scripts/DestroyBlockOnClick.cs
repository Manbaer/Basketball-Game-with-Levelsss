using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlockOnClick : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }

}
