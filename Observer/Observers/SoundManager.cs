using System;
using Observer.Core;

namespace Observer.Observers;

/// <summary>
/// 게임 사운드 효과 관리 옵저버 클래스
/// </summary>
public class SoundManager : IObserver
{
    /// <summary>
    /// 게임 이벤트 발생 시 적절한 사운드 효과 재생
    /// </summary>
    public void Update(string eventType, object? data)
    {
        switch (eventType)
        {
            case "ScoreChanged":
                Console.WriteLine("효과음 재생: 점수 획득!");
                break;

            case "PlayerDied":
                Console.WriteLine("효과음 재생: 플레이어 사망!");
                break;

            case "LevelCompleted":
                Console.WriteLine("효과음 재생: 레벨 클리어!");
                break;
        }
    }
}