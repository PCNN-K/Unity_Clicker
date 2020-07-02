using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private int m_gold = 0;
    private int m_goldPerClick = 0;

    void Awake()    //게임이 시작될 때 자동으로 실행된다. 따라서 게임이 처음 시작될 때 초기화 해야 하는 값들을 넣는다.
    {
        // KEY : VALUE 로 로컬에 저장
        // 키 값을 통해서 VALUE를 가져오고 저장할 수 있다.
        // 해당 키 값이 없으면 0을 가져온다.
        m_gold = PlayerPrefs.GetInt("Gold");
        m_goldPerClick = PlayerPrefs.GetInt("GoldPerClick", 1); // (A, B) -> A 키 값이 없으면 B로 설정하라
    }

    public void SetGold(int newGold)
    {
        m_gold = newGold;
        PlayerPrefs.SetInt("Gold", m_gold); //Get에 쓰이는 키 값과 Set에 쓰이는 키 값이 같아야 한다.
    }

    public void AddGold(int newGold)
    {
        //SetGold 함수를 재활용한다.
        m_gold += newGold;
        SetGold(m_gold);
    }

    public void SubGold(int newGold)
    {
        m_gold -= newGold;
        SetGold(m_gold);
    }

    public int GetGold()
    {
        //현재 골드 정보를 가져온다.
        return m_gold;
    }

    public int GetGoldPerClick()
    {
        //현재 클릭 당 골드 증가량 정보를 가져온다.
        return m_goldPerClick;
    }

    public void SetGoldPerClick(int newGoldPerClick)
    {
        m_goldPerClick = newGoldPerClick;
        PlayerPrefs.SetInt("GoldPerClick", m_goldPerClick);
    }
}
