namespace Observer.Core;

/// <summary>
/// 옵저버 패턴의 주제(Subject) 인터페이스
/// 옵저버들을 등록하고 관리하며, 이벤트 발생 시 옵저버들에게 알림
/// </summary>
public interface ISubject
{
    /// <summary>
    /// 새로운 옵저버 등록
    /// </summary>
    /// <param name="observer">등록할 옵저버</param>
    void RegisterObserver(IObserver observer);

    /// <summary>
    /// 등록된 옵저버 제거
    /// </summary>
    /// <param name="observer">제거할 옵저버</param>
    void RemoveObserver(IObserver observer);

    /// <summary>
    /// 등록된 모든 옵저버에게 이벤트 알림
    /// </summary>
    /// <param name="eventType">이벤트 타입</param>
    /// <param name="data">이벤트 데이터</param>
    void NotifyObservers(string eventType, object? data);
}