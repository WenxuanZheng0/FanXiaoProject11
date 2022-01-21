using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///<summary>
///
///</summary>
public class PlayButton : MonoBehaviour
{
    public GameObject loading;
    private void Awake()
    {
        loading.SetActive(false);
    }
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //当前场景的下一个场景
        transform.gameObject.SetActive(false);
        loading.SetActive(true);
        SceneManager.LoadScene(1);
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}
