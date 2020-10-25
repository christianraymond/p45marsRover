# MARSROVER
A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on-board cameras can get a complete view of the surrounding terrain to send back to Earth. <br/>

A rover's position and location is represented by a combination of x and y co-ordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation.<br/>

An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.

In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading.<br/>
Assume that the square directly North from (x, y) is (x, y+1).

## INPUT

The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have been deployed. Each rover has two lines of input. <br/>

The first line gives the rover's position, and the second line is a series of instructions telling the rover how to explore the plateau. 
The position is made up of two integers and a letter separated by spaces, corresponding to the x and y co-ordinates and the rover's orientation. <br/>

Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving.

## OUTPUT
The output for each rover should be its final co-ordinates and heading.

## INPUT AND OUTPUT

Test Input:

5 5

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM

Expected Output

1 3 N

5 1 E

## How to Run the Application
The application is a console app designed for the .NET 3+ framework. It does not use any of the features of .NET 3.0 or 3.5, however can be configured to build for any desired. NET version within Visual Studio.
Clone(Download) the repository into your machine
Compile the solution, and then run the application as follows:

```p45Rover.exe <windows-path-to-input-file``` or after cloning, open the project inside visual studio, eg: visual studio 2019 and do a build and then
```Run Start``` <br/>

If you're a familiar with visual studio or have a little basics building C# project, you should be good to do, just in case.
The input file path can be absolute or relative. Instructions are provided if no argument or more than one argument is supplied to the application.

## Design Explanation

I have programmed my solution to follow object-oriented design patterns and best practices to the best of my current knowledge and ability. <br/>

I refactored a bunch of lines of code to keep it less complex but easy to use, also this is done to enable scalability of code as well as future modifications to be completed easily without the need for heavy refactoring. <br/>

The solution consists of a RoverCoordinator class, UnitTest class and MarsRover class which houses the static main method. <br/>

## Tools used
Language: C#

IDE: Visual Sudio 2019

OS: Windows 10 Pro 64-bit

## Thanks
Thanks very much for your time and consideration, and have a terrfic day!

Sincerely,

Christian Ngubana








