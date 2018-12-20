﻿using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    private GameState m_CurrentGameState;

    public void ChangeGameState(GameState newGameState)
    {
        m_CurrentGameState = newGameState;
    }

    public GameState GetGameState()
    {
        return m_CurrentGameState;
    }
}

public enum GameState
{
    StartGame = 0,
    MakingPrediction,
    Rollin,
    Rolled
}