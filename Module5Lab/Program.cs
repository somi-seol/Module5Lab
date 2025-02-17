using Module5Lab;

// create new player with 1 life and add points to player score
Player player = new Player("Frankenstein", 1);
player.AddPoints(100);

// display player score
Console.WriteLine("Welcome to the game! Your score is: " + player.GetScore() + 
    " You have " + player.GetLivesLeft() + " lives left!");

// kill player character
player.Kill();

// death msg
Console.WriteLine("An orc attacks you. Sorry, you were killed. You have " 
    + player.GetLivesLeft() + " lives left!");

// create super player
SuperPlayer superPlayer = new SuperPlayer();
superPlayer.AddPoints(200);
superPlayer.Fly(); // demo Superplayer method
Console.WriteLine($"SuperPlayer score: {superPlayer.GetScore()}, Lives left: {superPlayer.GetLivesLeft()}");   