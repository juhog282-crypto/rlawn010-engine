using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        // 1. 플레이 시간 (시:분:초, 분/초는 항상 두 자리)
        int hour = playSeconds / 3600;
        int min = playSeconds % 3600 / 60;
        int sec = playSeconds % 60;
        Debug.Log("플레이 시간 " + hour + ":" + (min / 10) + (min % 10) + ":" + (sec / 10) + (sec % 10));

        // 2. 골드 분배
        int goldPerMember = gold / members;
        int leaderBonus = gold % members;
        Debug.Log("1인당 " + goldPerMember + "G, 리더 보너스 " + leaderBonus + "G");

        // 3. 경험치 (소수점 버림)
        int baseExp = kills * expPerKill;
        int finalExp = (int)(baseExp * expRate);
        Debug.Log("경험치 " + finalExp + " (기본 " + baseExp + ")");

        // 4. 레벨 (레벨마다 100 필요, 1부터 시작)
        int level = finalExp / 100 + 1;
        int expToNext = 100 - finalExp % 100;
        Debug.Log("Lv " + level + ", 다음 레벨까지 " + expToNext);

        // 5. 평균 데미지 (소수까지)
        float avgDamage = (float)totalDamage / hits;
        Debug.Log("평균 데미지 " + avgDamage);
    }
}