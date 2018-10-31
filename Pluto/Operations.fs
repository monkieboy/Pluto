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
    | F -> { rover with Y = rover.Y + 1 }
    | _ -> failwith "Unexpected command"
