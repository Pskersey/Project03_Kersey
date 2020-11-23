using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar_cs : MonoBehaviour
{
    public Slider _manaSlider;

    public void SetMaxMana(float mana)
    {
        _manaSlider.maxValue = mana;
        _manaSlider.value = mana;
    }

    public void SetMana(float mana)
    {
        _manaSlider.value = mana;
    }
}

