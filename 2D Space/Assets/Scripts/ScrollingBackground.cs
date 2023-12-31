using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;
    [SerializeField]
    private Renderer bRenderer;
    public GameObject gameOverPanel;
    public GameObject gameWon;
    // Start is called before the first frame update
    void Start()
    {
        
        gameOverPanel.SetActive(false);
        gameWon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bRenderer.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
        
    }

    public void show()
    {
        gameOverPanel.SetActive(true);
    }

    public void gameWonShow()
    {
        gameWon.SetActive(true);
    }

    public void reload()
    {
        SceneManager.LoadScene("Game");
    }
}
