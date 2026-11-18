using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;  // 몬스터 한 마리의 경험치
    public int killCount = 3;       // 잡은 마릿수

    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;

        // 몬스터를 한 마리씩 잡음 (for)
        for (int i = 1; i <= killCount; i++)
        {
            exp += expPerKill;

            // 한 마리에 여러 번 레벨업할 수 있으니 while로 반복 검사
            while (exp >= level * 10000)
            {
                exp -= level * 10000;
                level++;
                Debug.Log("레벨업! Lv " + level + " (" + i + " 마리째)");
            }
        }

        Debug.Log("최종 Lv " + level + ", 경험치 " + exp + " / " + (level * 10000));
    }
}