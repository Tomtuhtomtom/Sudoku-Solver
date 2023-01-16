using SudokuSolver.Tools;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Sudoku Solver");
Console.WriteLine("Instruction: Copy Sudoku line by line with 'x' as empty space.");
Console.WriteLine("Then watch it solve it!");
Console.WriteLine("Your Sudoku:");

Solver.Input();
var solution = string.Join("\n", Solver.Solve());

Console.WriteLine();
Console.WriteLine("Solution:");
Console.Write(solution);
Console.WriteLine();
Console.WriteLine();
Console.ReadLine();