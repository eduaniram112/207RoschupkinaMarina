using System;
// задача 4 из презенатции 1
namespace Task02
{
    class Robot
    {
        public static char[,] output;

        // Положение робота на плоскости.
        int x, y;

        public void Right()
        {
            if (x > output.GetLength(0)) throw new Exception("Respect my boundaries");
            x++;
            TraceOfRobot();
        }

        public void Left()
        {
            if (x < 0) throw new Exception("Respect my boundaries");
            x--;
            TraceOfRobot();
        }

        public void Forward()
        {
            if (y < 0) throw new Exception("Respect my boundaries");
            y--;
            TraceOfRobot();
        }

        public void Backward()
        {
            if (y > output.GetLength(0)) throw new Exception("Respect my boundaries");
            y++;
            TraceOfRobot();
        }

        private void TraceOfRobot()
        {
            output[y, x] = '+';
        }

        public int GetX() => x;
        public int GetY() => y;

        public string Position() => String.Format("The Robot position: x={0}, y={1}", x, y);
        public string Pos() => String.Format("x = {0}, y = {1}", x, y);

    }


    class Program
    {
        delegate void Steps();

        static void Main(string[] args)
        {

            Robot robot = new Robot();
            string start = robot.Pos();
            Steps cmd = null;
            bool flag = false;

            SetField();
            HandleInputCommand(robot, ref cmd, ref flag);

            if (flag)
                Console.WriteLine("Incorrect input command!");
            else
            {
                try
                {
                    cmd();
                    Console.WriteLine($"Start position {start}");
                    Console.WriteLine($"Current position {robot.Pos()}");
                    start = robot.Pos();
                    PrintField(robot);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        private static void PrintField(Robot robot)
        {
            var curentX = robot.GetX();
            var curentY = robot.GetY();

            Robot.output[0, 0] = '+';
            char[] lineArray = new char[Robot.output.GetLength(0)];
            for (int i = 0; i < Robot.output.GetLength(0); i++)
                lineArray[i] = '-';
            string line = String.Join("", lineArray);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(line);

            for (int i = 0; i < Robot.output.GetLength(0); i++)
            {
                for (int j = 0; j < Robot.output.GetLength(1); j++)
                {
                    if (j == curentX && i == curentY)
                    {
                        Console.Write('*');
                    }
                    else
                        Console.Write(Robot.output[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(line);
            Console.ResetColor();

        }

        private static void HandleInputCommand(Robot robot, ref Steps cmd, ref bool flag)
        {
            Console.WriteLine("Enter command");
            string inputCommand = Console.ReadLine();
            foreach (var command in inputCommand)
            {
                switch (command)
                {
                    case 'R':
                        cmd += robot.Right;
                        break;
                    case 'L':
                        cmd += robot.Left;
                        break;
                    case 'F':
                        cmd += robot.Forward;
                        break;
                    case 'B':
                        cmd += robot.Backward;
                        break;
                    default:
                        flag = true;
                        break;
                }
            }
        }

        private static void SetField()
        {
            int sizeField;
            do
            {
                Console.WriteLine("Enter field size");
            } while (!int.TryParse(Console.ReadLine(), out sizeField) || sizeField < 1);

            Robot.output = new char[sizeField, sizeField];
            for (int i = 0; i < sizeField; i++)
                for (int j = 0; j < sizeField; j++)
                    Robot.output[i, j] = ' ';
        }

    }
}
