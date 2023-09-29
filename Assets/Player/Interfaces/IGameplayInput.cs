using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGameplayInput
{
	public event Action<float> VerticalMovement;
	public event Action<Vector2> HorizontalMovement;
	public event Action<float> Roll;
}
