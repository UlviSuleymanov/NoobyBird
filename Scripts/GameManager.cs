
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool isDead=false;
    public GameObject gameOverElement;
    public GameObject restartElement;
    public GameObject exitElement;
    public AudioSource music;

    private void Start()
    {
        gameOverElement.SetActive(false);
        restartElement.SetActive(false);
        exitElement.SetActive(false);
        music.Play();
    }
    
    public void Restart()
    {
       
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        isDead = false;
        gameOverElement.SetActive(false);
        restartElement.SetActive(false);
        exitElement.SetActive(false);
    }
    public void SetDead()
    {
        isDead = true;
        
    }

    public void Mute()
    {
        music.mute=true;
    }

    public void UnMute()
    {
        music.mute = true;
    }
    private void Update()
    {
        if (isDead)
        {
            gameOverElement.SetActive(true);
            restartElement.SetActive(true);
            exitElement.SetActive(true);
            music.Stop();
        }
    }
}
