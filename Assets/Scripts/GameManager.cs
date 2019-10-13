
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    private bool gameHastopped = false;
    public Rotator rotator;
    public Spawner spawner;

    public Animator animator;
    public void StopGame()
    {

    }
    public void EndGame()
    {
        if (gameHasEnded)
            return;

        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGame");
        gameHasEnded = true;
        Debug.Log("END GAME");

    }

    public void RestartLevel()
    {
        Rounds.roundCount++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
