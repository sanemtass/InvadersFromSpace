using UnityEngine;

[System.Serializable]

public class ShipStats
{
    [Range(1, 5)]
    public int maxHealth;
    [HideInInspector]
    public int maxLifes = 3;
    [HideInInspector]
    public int currentLifes = 3;
    public int currentHealth = 3;

    public float shipSpeed;
    public float fireRate;
}
