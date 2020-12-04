﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage, speed, knockback;
    public int durability, maxDurability;
    public string weaponName;

    Handle handle;
    Hilt hilt;
    Blade blade;

    public void GetStats()
    {
        damage = handle.damage + hilt.damage + blade.damage;
        knockback = handle.knockback + hilt.knockback + blade.knockback;
        speed = handle.speed + hilt.speed + blade.speed;
        durability = handle.durability + hilt.durability + blade.durability;
        maxDurability = durability;
    }

    public void GetName()
    {
        weaponName = AINamesGenerator.Utils.GetRandomName();
        name = weaponName;
    }

    public void SetParts(GameObject handles, GameObject hilts, GameObject blades)
    {
        handle = handles.GetComponent<Handle>();
        hilt = hilts.GetComponent<Hilt>();
        blade = blades.GetComponent<Blade>();

        GetStats();
        GetName();
    }
}
