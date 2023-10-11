
Player player1 = new Player();
Player player2 = new Player();

player1.Attack(player2);
Console.WriteLine($"Player 1 damage: {player1.damage}, Player 2 damage: {player2.damage}");
player2.Attack(player1);
Console.WriteLine($"Player 1 damage: {player1.damage}, Player 2 damage: {player2.damage}");
player1.Attack(player1);
Console.WriteLine($"Player 1 damage: {player1.damage}, Player 2 damage: {player2.damage}");
Player player3 = player1;
player2.Attack(player3);
Console.WriteLine($"Player 1 damage: {player1.damage}, Player 2 damage: {player2.damage}, Player 3 damage: {player3.damage}");



