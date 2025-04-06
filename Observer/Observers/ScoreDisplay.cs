using System;
using Observer.Core;

namespace Observer.Observers;

/// <summary>
/// 게임 점수 화면 표시 옵저버 클래스
/// </summary>
public class ScoreDisplay : IObserver
{
    /// <summary>
    /// 점수 변경 이벤트 발생 시 화면 표시
    /// </summary>
    public void Update(string eventType, object? data)
    {
        if (eventType == "ScoreChanged" && data != null)
        {
            int score = (int)data;
            Console.WriteLine($"현재 점수: {score}");
        }
    }
}