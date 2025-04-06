namespace Observer.Core;

/// <summary>
/// 옵저버 인터페이스
/// 이벤트 발생 시 업데이트되는 객체 정의
/// </summary>
public interface IObserver
{
    /// <summary>
    /// 이벤트 발생 시 호출되는 메서드
    /// </summary>
    /// <param name="eventType">발생한 이벤트 타입</param>
    /// <param name="data">이벤트와 관련된 데이터</param>
    void Update(string eventType, object? data);
}