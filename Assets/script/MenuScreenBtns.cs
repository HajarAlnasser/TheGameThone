
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuScreenBtns : MonoBehaviour
{

    [SerializeField] private GameObject instruction, mainPanel, whenStart, backButton, backTonInstructionButton, backToOptionButton, optionPanel, musicButton;


    private void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(whenStart);
    }
    public void StartGame()
    {
        Time.timeScale = 1;
        print("startGame");
        SceneManager.LoadScene("waleed");

    }
    public void InstructionPannel()
    {
        mainPanel.SetActive(false);
        instruction.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(backButton);



    } public void optionPannel()
    {
        mainPanel.SetActive(false);
        optionPanel.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(musicButton);



    }
    public void backToMenuPanel()
    {
        instruction.SetActive(false);
        mainPanel.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(backTonInstructionButton);

    }    public void CLOSEOption()
    {      optionPanel.SetActive(false);
        mainPanel.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(backToOptionButton);

    }

  


    public void Quit()
    {
        Application.Quit();

    }

}
