using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kutupayisi : MonoBehaviour
{
    [SerializeField] private Image resim;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("resim"))
        {
            resim.enabled = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("resim"))
        {
            resim.enabled = false;
        }
    }
}
