using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class LoadMain : MonoBehaviour
{
    private int secondsToPass;

    // Start is called before the first frame update
    void Start()
    {
        secondsToPass = 4;
        StartCoroutine(LoadMainScene());
    }

    IEnumerator LoadMainScene()
    {
        while (secondsToPass > 0)
        {
            yield return new WaitForSeconds(1);
            secondsToPass--;
            GetComponent<TextMeshProUGUI>().text = "Loading Main in " + secondsToPass + " seconds...";
        }
        SceneManager.LoadScene(1);
    }
}
