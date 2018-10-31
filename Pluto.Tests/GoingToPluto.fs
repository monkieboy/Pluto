module Tests

open Expecto
open Exercise

[<Tests>]
let tests =
  let pluto = { XLength = 100; YLength = 100 }

  let rover = landOn pluto

  testList "Going to Pluto" [
    testCase "Starting loc is 0,0 N" <| fun _ ->

      let loc = rover.getLoc ()

      Expect.equal loc { X = 0; Y = 0; Heading = N } "Starting location after landing should be 0,0 N"

    testCase "Move forward so loc is 0,1 N" <| fun _ ->
      let rover' = sendCommand F rover

      let loc = rover'.getLoc()

      Expect.equal loc { X = 0; Y = 1; Heading = N } "Location after moving forward should be 0,1 N"
      
  ]
