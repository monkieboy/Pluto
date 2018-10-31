module Tests

open Expecto
open Exercise

[<Tests>]
let tests =
  testList "Going to Pluto" [
    testCase "Starting loc is 0,0 N" <| fun _ ->
      let pluto = { XLength = 100; YLength = 100 }

      let rover = landOn(pluto)

      let loc = rover.getLoc()

      Expect.equal loc { X = 0; Y = 0; Heading = N } "Starting location after landing should be 0,0 N"
  ]
