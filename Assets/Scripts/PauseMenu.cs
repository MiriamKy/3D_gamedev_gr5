<<<<<<< HEAD
using JetBrains.Annotations;
using UnityEngine;
 
 public class PauseMenu : MonoBehaviour
{
=======
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

>>>>>>> origin/UI_Work
    // Referanse til PauseMenu gameobjektet vårt. Dette er panelet vi vil skru av og på
    [SerializeField] private GameObject pauseMenu;

    // En måte å se om spillet er pauset eller ikke
    private bool isPaused = false;

<<<<<<< HEAD
    // På hver frame har lyst til å se om spilleren har trykket på escape
    private void Update()
    {
        // Hvis spilleren har trykket på escape, så vil vi gjøre noe
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Hvis spilleren vår trykker på escape og spillet IKKE er pauset, gjør:
            if (!isPaused)
            {
=======

    // På hver frame har lyst til å se om spilleren har trykket på escape
    private void Update()
    {

        // Hvis spilleren har trykket på escape, så vil gjøre noe
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            // Hvis spilleren vår trykker på escape og spillet IKKE er pauset, gjør:
            if (!isPaused)
            {

>>>>>>> origin/UI_Work
                // Aktiver menyen vår
                pauseMenu.SetActive(true);
                // Stoppe tiden
                Time.timeScale = 0;
                // Sett isPaused til true
                isPaused = true;
<<<<<<< HEAD
            }
            else
            {
                // Motsatt av alt ovenfor - Unpause
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                isPaused = false;
            }
        }
=======

            }
            else
            {
                // Hvis spilleren på escape og spillet ER pauset, gjør: 
                // Motsatt av alt ovenfor
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
                isPaused = false;

            }

        }




>>>>>>> origin/UI_Work
    }

    // Public metode for å starte spillet - Resume
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
<<<<<<< HEAD
    }

    // Public metode for å avslutte spillet - Quit.
    public void QuitGame()
    {
        Debug.Log("Spillet avsluttes!");
        Application.Quit();
    }

=======

    }

    // Public metode for å avslutte spillet -   Quit
    public void QuitGame()
    {
        Debug.Log("Spillet AVSLUTTER!");
        Application.Quit();
    }

    public void Settings()
    {

    }

>>>>>>> origin/UI_Work
}
