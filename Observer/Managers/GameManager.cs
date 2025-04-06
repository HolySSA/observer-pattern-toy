using System.Collections.Generic;
using Observer.Core;

namespace Observer.Managers;

/// <summary>
/// 게임 주요 상태 관리, 옵저버들에게 이벤트를 알리는 게임 매니저 클래스
/// </summary>
public class GameManager : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private int score = 0;

    /// <summary>
    /// 새로운 옵저버 등록
    /// </summary>
    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    /// <summary>
    /// 등록된 옵저버 제거
    /// </summary>
    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    /// <summary>
    /// 등록된 모든 옵저버에게 이벤트 알림
    /// </summary>
    public void NotifyObservers(string eventType, object? data)
    {
        foreach (var observer in observers)
        {
            observer.Update(eventType, data);
        }
    }

    /// <summary>
    /// 플레이어 점수 추가, 관련 옵저버들에게 알림
    /// </summary>
    /// <param name="points">추가할 점수</param>
    public void AddScore(int points)
    {
        score += points;
        NotifyObservers("ScoreChanged", score);
    }

    /// <summary>
    /// 플레이어 사망을 옵저버들에게 알림
    /// </summary>
    public void PlayerDied()
    {
        NotifyObservers("PlayerDied", null);
    }

    /// <summary>
    /// 레벨이 완료되었음을 옵저버들에게 알림
    /// </summary>
    public void LevelCompleted()
    {
        NotifyObservers("LevelCompleted", null);
    }
}