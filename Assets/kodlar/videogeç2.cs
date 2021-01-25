using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class videogeç2 : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(bekle());
    }

    IEnumerator bekle()
    {
        yield return new WaitForSeconds(70); 
        SceneManager.LoadScene("kutupelcisi"); //scene ismi
    }
}