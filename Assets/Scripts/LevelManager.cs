using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;

    [SerializeField] private Transform player; 
    [SerializeField] private Transform box;
    [SerializeField] private Transform target;
    [SerializeField] private GameObject winPanel; // "Level Complete!" yazısı olan UI objesi

    private Vector3 playerStartPos;
    private Vector3 boxStartPos;

    void Awake()
    {
        // TODO: Singleton kur (Instance = this)
        Instance = this;
    }

    private struct MoveState
    {
        public Vector3 playerPosition;
        public Vector3 boxPosition;
    }

    private Stack<MoveState> moveHistory = new Stack<MoveState>();

    void Start()
    {
        // TODO: winPanel'i başlangıçta kapat (SetActive(false))
        winPanel.SetActive(false);
        // TODO: playerStartPos ve boxStartPos değerlerini ata
        playerStartPos = player.position;
        boxStartPos = box.position;
    }

    void Update()
    {
        // TODO: box.position ile target.position'ı karşılaştır
        if (box.position == target.position)
        {
            // TODO: eşitse winPanel'i aç (SetActive(true))
            winPanel.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Undo();
        }
    }
    
    public void Reset()
    {
        player.position = playerStartPos;
        box.position =boxStartPos;
        winPanel.SetActive(false);
        moveHistory.Clear();
    }

    public void SaveState()
    {
        MoveState state = new MoveState
        {
            playerPosition = player.position,
            boxPosition = box.position
        };
        moveHistory.Push(state);
    }

    public void Undo()
    {
        if (moveHistory.Count > 0)
        {
            MoveState lastState = moveHistory.Pop();
            player.position = lastState.playerPosition;
            box.position = lastState.boxPosition;
            winPanel.SetActive(false);
        }
    }

    public void NextLevel()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextIndex > 5)
        {
            SceneManager.LoadScene("LevelSelect");
        }
        else
        {
           SceneManager.LoadScene(nextIndex);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    } 

    public void GoToLevelSelect()
    {
        SceneManager.LoadScene("LevelSelect");
    }

}