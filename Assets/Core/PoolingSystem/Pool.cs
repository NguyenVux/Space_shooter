using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Pool 
{
	[SerializeField] private List<GameObject> m_pool;
	[SerializeField] private int size;
}
