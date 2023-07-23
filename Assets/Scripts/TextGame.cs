using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class TextGame : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI storytextMeshPro;
    public string StoryText;
    public GameObject MainMenuButtons, Level1Choices, Level2Choices, Level3Choices, Restart;

    void Start()
    {
        storytextMeshPro.text = StoryText;
        StoryText = "Nightwalker";
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
        Level3Choices.SetActive(false);
        Restart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        storytextMeshPro.text = StoryText;
    }

    public void startGame()
    {
        MainMenuButtons.SetActive(false);
        Level1Choices.SetActive(true);
        Level2Choices.SetActive(false);
        Level3Choices.SetActive(false);
        StoryText = "You are wandering the forest at night\nThen you see a dark figure nearing you.\n\nWhat will you do?";
    }

    public void exit()
    {
        Application.Quit();
    }

    public void Button1()
    {
        StoryText = "It was a monster! \nYou died from a scratch on the chest.";
        Level1Choices.SetActive(false);
        Restart.SetActive(true);
    }

    public void Button2()
    {
        StoryText = "The dark figure is nowhere to be seen.\nYou heard a loud scream.\n\nWhat will you do?";
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(true);
        Level3Choices.SetActive(false);
    }

    public void REDO()
    {
        storytextMeshPro.text = StoryText;
        StoryText = "Nightwalker";
        MainMenuButtons.SetActive(true);
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
        Level3Choices.SetActive(false);
        Restart.SetActive(false);
    }
   
    public void Button3()
    {
        StoryText = "A dying man tells you there's a monster.\nHe told you to take his weapon.\nYou heard a roar. What will you do?";
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
        Level3Choices.SetActive(true);
    }

    public void Button4()
    {
        StoryText = "You ran to the monster! You were ripped apart.";
        Level2Choices.SetActive(false);
        Restart.SetActive(true);
    }

    public void Button5()
    {
        StoryText = "You killed the monster because it was wounded before your fight.\nYou were able to get out of the forest safely.";
        Level1Choices.SetActive(false);
        Level2Choices.SetActive(false);
        Level3Choices.SetActive(false);
        Restart.SetActive(true);
    }

    public void Button6()
    {
        StoryText = "The monster snuck up on you!\nYou lost so much blood when it slashed your back.";
        Level3Choices.SetActive(false);
        Restart.SetActive(true);
    }
}


