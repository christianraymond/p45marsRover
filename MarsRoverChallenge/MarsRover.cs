using System;
using System.Linq;

namespace p45Rover
{
    class MarsRover
    {
        static void Main(string[] args)
        {
            //Summary
            //Program receiving Given Inputs Inputs 
            //Summary
            var inputs = @"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM".Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            var bounds = inputs[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
            var dirs = "NESW";
            var magnitudes = new[] { Tuple.Create(0, 1), Tuple.Create(1, 0), Tuple.Create(0, -1), Tuple.Create(-1, 0) };
            for (int i = 1; i < inputs.Length; i += 2)
            {
                var start = inputs[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var x = int.Parse(start[0]); var y = int.Parse(start[1]);
                var direction = dirs.IndexOf(start[2]);
                //Control the rover with string of Input
                //1. The first line gives the rover's position
                //2. The second line is a serie of instruction telling the rover how to explore the plateau.
                foreach (var command in inputs[i + 1])
                    switch (command)
                    {
                        case 'L': direction = (--direction + magnitudes.Length) % magnitudes.Length; break;
                        case 'R': direction = ++direction % magnitudes.Length; break;
                        default: x = Math.Min(bounds[0], Math.Max(0, x + magnitudes[direction].Item1)); y = Math.Min(bounds[1], Math.Max(0, y + magnitudes[direction].Item2)); break;
                    }
                //Expected Output inside cmd
                // 1 3 N
                // 5 1 E
                Console.WriteLine(x + " " + y + " " + dirs[direction]);
            }
            Console.ReadKey();
        }
    }
}
