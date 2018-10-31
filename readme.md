# Pluto Rover

## To run the tests:

    dotnet run --project Pluto.Tests

## Types

There are 5 types:
 * Heading
    - so that it is restricted to only the headings that are valid, subject to compile time checks.
 * Move
    - to make sure the moves are typed
 * Planet
    - to store the dimensions of the grid
 * Loc
   - It will represent a location and heading.
 * Rover
   - Will hold the state for the rover that has landed on Pluto.
   - Will have a series of functions that allow it to provide feedback, all driven out by tests.

## Operations

There will an Operations module that will handle the actions available, that will operate on the Rover.

## Further improvements

1) Look at the sendCommand function to reduce the number of pattern matches, currently it isn't that long but with some thought could come up with something a little pleasing to the eye. Small value added by making this change at this point as it isn't a crazy amount of matches.... yet.

2) Error handing in the sendCommand should be done with a Result type as the parseCommand does, but I didn't think of it until much later.

3) Create another function to stream a series of chars, this would internally call parseCommand

4) Move parseCommand inside the Rover type as it isn't really a function that mission control should have access to. Maybe add a receiver on the Rover that takes the string commands and passes to parseCommand, it would likely be called from sendCommand as part of the pattern matches.