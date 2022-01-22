using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
///<summary>
///
///</summary>
public class videoController : MonoBehaviour
{
    public VideoPlayer m_VideoPlayer;
    [SerializeField] private GameObject loading;
    [SerializeField] private GameObject VideoScreen;

    void Awake()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += OnMovieFinished; // loopPointReached is the event for the end of the video
        loading.SetActive(false);
        VideoScreen.SetActive(true);
    }

    void OnMovieFinished(VideoPlayer player)
    {
        Debug.Log("Event for movie end called");
        loading.SetActive(true);
        player.Stop();
        VideoScreen.SetActive(false);
        SceneManager.LoadScene(2);
    }
}
