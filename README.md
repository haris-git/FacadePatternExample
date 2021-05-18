# FacadePatternExample
This is a facade pattern example, implemented in C# .NET Core 5.0 as a console application.
The example simulates the case of watching a movie in a home theater system.

# Explanation of the facade pattern
The facade pattern provides a unified interface that makes all the subsystems easier to use. In the current project, I implement a virtual hometheater. When I decide to watch a movie, I have to do many successive actions before being able to actually watch the movie. The same difficulties exist when the movie end and I want to turn off the home theater system. With the facade pattern, as a user I can only choose to watch a movie, and everything is configured behind the scenes. For more information check the **Program.cs**.
