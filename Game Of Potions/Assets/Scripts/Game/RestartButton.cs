using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    [SerializeField] Button _restartButton;

    public void RestartGame()
    {
        Debug.Log("Passou na função");
        SceneManager.LoadScene(0);
    }
}
