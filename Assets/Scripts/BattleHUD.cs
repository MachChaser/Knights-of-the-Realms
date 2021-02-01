using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text nameText;
    public Text levelText;
    public Slider hpSlider;
    public int levels;

    public void Start()
    {
        levels = 0;
    }
    public void SetHUD(Unit unit)
    {
        nameText.text = unit.unitName;
        unit.unitLevel += levels;
        levelText.text = "LVL: " + unit.unitLevel;
        hpSlider.maxValue = unit.maxHP;
        hpSlider.value = unit.currentHP;
    }

    public void SetHP(int hp)
    {
        hpSlider.value = hp;
       
    }

    public void LevelUp(Unit unit)
    {
        levels += 1;
        unit.unitLevel = unit.unitLevel + 1;
        Debug.Log("Level: " + unit.unitLevel);
        levelText.text = "LVL: " + unit.unitLevel;
    }


}
