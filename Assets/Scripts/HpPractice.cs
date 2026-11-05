using UnityEngine;

public class HpPractice : MonoBehaviour
{
    private int currentHp;
        private int maxHp;
    [ContextMenu("체력")]
    void PrintHp()
    {
        int a = (int)((float)currentHp / maxHp * 100);           // 방법 1
        Debug.Log("HP " + a + "%");
    }

}
