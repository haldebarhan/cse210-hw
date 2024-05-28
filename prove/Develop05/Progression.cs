class Progression
{
    private int _level;
    private int _currentScore;
    private int _scoreToReach;
    private int _scoreForCurrentLevel;
    private int _minimumScoreForCurrentLevel;

    public Progression(int level, int currentScore, int scoreForCurrentLevel = 0, int scoreToReach = 1000)
    {
        _level = level;
        _currentScore = currentScore;
        _scoreToReach = scoreToReach;
        _scoreForCurrentLevel = scoreForCurrentLevel;
        _minimumScoreForCurrentLevel = 0;
    }

    public int GetMinimumScoreForCurrentLevel()
    {
        return _minimumScoreForCurrentLevel;
    }
    public int GetScoreForCurrentLevel()
    {
        return _scoreForCurrentLevel;
    }

    public void SetScoreForCurrentLevel(int score)
    {
        _scoreForCurrentLevel = score;
    }

    public int GetLevel()
    {
        return _level;
    }

    public int GetCurrentScore()
    {
        return _currentScore;
    }

    public int GetScoreToReach()
    {
        return _scoreToReach;
    }

    public void SetLevel(int level)
    {
        _level = level;
    }

    public void SetCurrentScore(int currentScore)
    {
        _currentScore = currentScore;
    }

    public void SetScoreToReach(int level)
    {
        _scoreToReach = level * 1000 + 500 * (level - 1);
    }

    public void DisplayProgress()
    {
        int progressBarWidth = 50;
        int progress = (int)((double)_currentScore / _scoreToReach * progressBarWidth);

        // Save the current cursor position
        int currentCursorTop = Console.CursorTop;

        // Move the cursor to the start of the line where the progress bar will be displayed
        Console.SetCursorPosition(0, currentCursorTop);

        // Display the progress bar
        Console.Write("Progression [");
        for (int i = 0; i < progressBarWidth; i++)
        {
            if (i < progress)
                Console.Write("|");
            else
                Console.Write(" ");
        }
        int percentage = (int)((double)_currentScore / _scoreToReach * 100);
        Console.Write($"] {percentage}%\t{GetCurrentScore()}/{GetScoreToReach()}");

        // Display the score and level information on the next line
        Console.SetCursorPosition(0, currentCursorTop + 1);
        // Console.WriteLine($"{GetCurrentScore()}/{GetScoreToReach()}");
        Console.WriteLine($"Current Level: {GetLevel()}");

        // Restore the cursor position
        Console.SetCursorPosition(0, currentCursorTop);
    }
    public void UpToNextLevel()
    {
        _minimumScoreForCurrentLevel = _scoreToReach;
        SetLevel(GetLevel() + 1);
        SetScoreToReach(GetLevel());
        SetScoreForCurrentLevel(_minimumScoreForCurrentLevel); // Set previous score as the base for the next level
        // _currentScore = _scoreToReach; // Ensure current score starts at the new base
        Console.SetCursorPosition(0, Console.CursorTop + 2);
        Console.WriteLine($"Congratulations! You've reached level {GetLevel()}");
    }

    public void AddScore(int score)
    {
        int targetScore = _currentScore + score;
        while (_currentScore < targetScore)
        {
            _currentScore++;
            _scoreForCurrentLevel++;
            if (_scoreForCurrentLevel >= _scoreToReach)
            {
                UpToNextLevel();
            }
            DisplayProgress();
            Thread.Sleep(10); // Adjust for smoother or faster animation
        }
        // Ensure the cursor is at the end of the line after the animation
        Console.SetCursorPosition(0, Console.CursorTop + 2);
    }


    public void LoadProgression(int score)
    {
        int newlevel = 1;
        int tempScore = score;
        int requiredScore = 1000;
        while (tempScore >= requiredScore)
        {
            newlevel++;
            tempScore -= requiredScore;
            requiredScore = newlevel * 1000 + 500 * (newlevel - 1);
        }

        SetLevel(newlevel);
        SetScoreToReach(newlevel);
        SetScoreForCurrentLevel(tempScore);
        SetCurrentScore(score);

        DisplayProgress();
    }
}
