using System;
using Observer.Core;
using Observer.Managers;
using Observer.Observers;

// 게임 매니저 생성
var gameManager = new GameManager();

// 옵저버들 생성
var scoreDisplay = new ScoreDisplay();
var achievementSystem = new AchievementSystem();
var soundManager = new SoundManager();

// 옵저버들을 게임 매니저에 등록
gameManager.RegisterObserver(scoreDisplay);
gameManager.RegisterObserver(achievementSystem);
gameManager.RegisterObserver(soundManager);

Console.WriteLine("게임 시작!\n");

// 게임 이벤트 시뮬레이션
Console.WriteLine("플레이어가 점수를 획득합니다...");
gameManager.AddScore(100);
Console.WriteLine();

Console.WriteLine("플레이어가 사망했습니다...");
gameManager.PlayerDied();
Console.WriteLine();

Console.WriteLine("플레이어가 레벨을 클리어했습니다...");
gameManager.LevelCompleted();
Console.WriteLine();

// 옵저버 제거 테스트
Console.WriteLine("사운드 매니저를 제거합니다...");
gameManager.RemoveObserver(soundManager);
Console.WriteLine();

Console.WriteLine("추가 점수를 획득합니다...");
gameManager.AddScore(150);
Console.WriteLine();

Console.WriteLine("프로그램을 종료하려면 아무 키나 누르세요...");
Console.ReadKey();