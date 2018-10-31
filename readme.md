# Pluto Rover

## To run the tests:

    dotnet run --project Pluto.Tests

## Types

There will be 4 types:
 * Heading
    - so that it is restricted to only the headings that are valid, subject to compile time checks.
 * Loc
   - It will represent a location and heading.
 * Rover
   - Will hold the state for the rover that has landed on Pluto.
   - Will have a series of functions that allow it to provide feedback, all driven out by tests.

## Operations

There will an Operations module that will handle the actions available, that will operate on the Rover.