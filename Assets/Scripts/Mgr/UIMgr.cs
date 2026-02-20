using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : MonoBehaviour
{
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject gameplayPanel;
    [SerializeField] private GameObject gameoverPanel;
    [SerializeField] private Text scoreTxt;
    [SerializeField] private Text finalScoreTxt;
    private int _score = 0;

    private void OnEnable()
    {
        GameEvents.OnGameStarted += ShowGamePlayPanel;
        GameEvents.OnGameStarted += ResetScore;
        GameEvents.OnGameOver += ShowGameOverPanel;
        GameEvents.OnGameOver += ShowFinalScore;
        GameEvents.OnDroneDestroy += UpdateScore;
    }
    
    private void OnDisable()
    {
        GameEvents.OnGameStarted -= ShowGamePlayPanel;
        GameEvents.OnGameStarted -= ResetScore;
        GameEvents.OnGameOver -= ShowGameOverPanel;
        GameEvents.OnGameOver -= ShowFinalScore;
        GameEvents.OnDroneDestroy -= UpdateScore;
    }

    private void ResetScore()
    {
        _score = 0;
        scoreTxt.text = "Score: " + _score;
    }

    private void UpdateScore()
    {
        _score++;
        scoreTxt.text = "Score: " + _score;
    }

    private void ShowFinalScore()
    {
        finalScoreTxt.text = "Your final score: " + _score;
    }

    public void OnRestartButtonPressed()
    {
        HideAllPanels();
        ShowStartPanel();
        GameEvents.OnGameStarted?.Invoke();
    }

    public void OnPlayButtonPressed()
    {
        HideAllPanels();
        ShowGamePlayPanel();
        GameEvents.OnGameStarted?.Invoke();
    }
    
    private void ShowGameOverPanel()
    {
        HideAllPanels();
        gameoverPanel.SetActive(true);
    }
    
    private void ShowGamePlayPanel()
    {
        HideAllPanels();
        gameplayPanel.SetActive(true);
    }

    private void ShowStartPanel()
    {
        HideAllPanels();
        startPanel.SetActive(true);
    }

    private void HideAllPanels()
    {
        startPanel.SetActive(false);
        gameplayPanel.SetActive(false);
        gameoverPanel.SetActive(false);
    }
}
