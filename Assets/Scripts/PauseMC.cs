using UnityEngine;
using System.Collections;

public class PauseMC : MonoBehaviour
{
    private Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (PauseMenu.GameIsPaused)
        {
            playerAnimator.enabled = false;
        } else
        {
            playerAnimator.enabled = true;
        }
    }
}
