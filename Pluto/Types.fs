namespace Exercise

[<AutoOpen>]
module Types =
  type Heading = N | E | S | W

  type Planet = {
      XLength : int
      YLength : int
    }

  type Loc = {
      X : int
      Y : int
      Heading : Heading
    }

  type Rover = {
      X : int
      Y : int 
      Heading : Heading
      OnPlanet : Planet
    }
    with member __.getLoc() = {
          X = __.X
          Y = __.Y
          Heading = __.Heading
        }