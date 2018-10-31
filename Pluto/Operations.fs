namespace Exercise

open Types

[<AutoOpen>]
module Operations =
  let landOn planet = {
    X = 0
    Y = 0
    Heading = N
    OnPlanet = planet
  }

  let sendCommand move rover =
    match move with
    | F when rover.Y = rover.OnPlanet.YLength -> { rover with Y = 0 }
    | F -> { rover with Y = rover.Y + 1 }
    | B when rover.Y = 0 -> { rover with Y = 100 }
    | R when rover.Heading = N -> { rover with Heading = E }
    | _ -> failwith "Unexpected command"
