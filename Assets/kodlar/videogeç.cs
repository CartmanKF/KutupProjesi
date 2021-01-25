using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videogeç : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(bekle());
    }

    IEnumerator bekle()
    {
        yield return new WaitForSeconds(23); 
        SceneManager.LoadScene("oyun"); //scene ismi
    }
}