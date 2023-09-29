using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private UA.PlayerInput m_playerInput;

	public UA.PlayerInput.GameplayActions GameplayActions => m_playerInput.Gameplay;



	void Awake()
    {
		GlobalServiceContainer.Register<InputManager, InputManager>(this);
		m_playerInput = new UA.PlayerInput();
		m_playerInput.Gameplay.Enable();
	}

	void OnDestroy()
	{
		GlobalServiceContainer.Unregister(this);
	}


}
