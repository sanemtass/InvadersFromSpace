using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    private Queue<GameObject> pooledObjects;
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private int poolSize;

	private void Awake()
	{
		pooledObjects = new Queue<GameObject>();
		for (int i = 0; i < poolSize; i++)
		{
			GameObject obj = Instantiate(objectPrefab);
			obj.SetActive(false);
			pooledObjects.Enqueue(obj); //siraya almak.
		}
	}

	public GameObject GetPooledObject()
	{
		GameObject obj = pooledObjects.Dequeue(); //siradan cikarmak.
		obj.SetActive(true);
		pooledObjects.Enqueue(obj);
		return obj;
	}

}
