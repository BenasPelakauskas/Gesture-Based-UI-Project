using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows.Speech;

public class MenuControl : MonoBehaviour
{
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    private void Start()
    {
        actions.Add("start", StartGame);
        actions.Add("menu", Menu);
        actions.Add("reset", Reset);

        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecognizedSpeech;
        keywordRecognizer.Start();

    }

    private void RecognizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    // Loads scene 1
    private void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // Loads Scene 0
    private void Menu()
    {
        SceneManager.LoadScene(0);
    }

    // Loads Scene 0
    private void Reset()
    {
        SceneManager.LoadScene(1);
    }
}
