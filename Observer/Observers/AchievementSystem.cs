using System;
using Observer.Core;

namespace Observer.Observers;

/// <summary>
/// 게임 업적 관리 옵저버 클래스
/// </summary>
public class AchievementSystem : IObserver
{
    private bool firstScoreAchieved = false;
    private bool firstDeathAchieved = false;
    private bool firstLevelCompleted = false;

    /// <summary>
    /// 게임 이벤트 발생 시 업적 달성 여부 확인 및 처리
    /// </summary>
    public void Update(string eventType, object? data)
    {
        switch (eventType)
        {
            case "ScoreChanged" when data != null:
                int score = (int)data;
                if (score > 0 && !firstScoreAchieved)
                {
                    Console.WriteLine("업적 달성: 첫 점수 획득!");
                    firstScoreAchieved = true;
                }
                break;

            case "PlayerDied":
                if (!firstDeathAchieved)
                {
                    Console.WriteLine("업적 달성: 첫 사망!");
                    firstDeathAchieved = true;
                }
                break;

            case "LevelCompleted":
                if (!firstLevelCompleted)
                {
                    Console.WriteLine("업적 달성: 첫 레벨 클리어!");
                    firstLevelCompleted = true;
                }
                break;
        }
    }
}