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

      let loc = rover'.getLoc ()

      Expect.equal loc { X = 0; Y = 1; Heading = N } "Location after moving forward should be 0,1 N"

    testCase "Move backward so loc is 0,100 N" <| fun _ ->
      let rover' = sendCommand B rover

      let loc = rover'.getLoc ()

      Expect.equal loc { X = 0; Y = 100; Heading = N } "Location after moving backward should be 0,100 N"

    testCase "Move forward from 0,100 while facing north so new loc is 0,0 N" <| fun _ ->
      let rover' = sendCommand B rover |> sendCommand F

      let loc = rover'.getLoc ()

      Expect.equal loc { X = 0; Y = 0; Heading = N } "Location after moving backward should be 0,100 N"

    testCase "Turning right while starting facing north now facing east" <| fun _ ->
      let rover' = sendCommand R rover

      let loc = rover'.getLoc ()
      
      Expect.equal loc { X = 0; Y = 0; Heading = E } "Location after turning right while facing north should be east"


    testCase "Turning left while starting facing north now facing west" <| fun _ ->
      let rover' = sendCommand L rover

      let loc = rover'.getLoc ()
      
      Expect.equal loc { X = 0; Y = 0; Heading = W } "Location after turning left while facing north should be west"


    testCase "Turning left while starting facing east now facing north" <| fun _ ->
      let rover' = sendCommand R rover |> sendCommand L

      let loc = rover'.getLoc ()
      
      Expect.equal loc { X = 0; Y = 0; Heading = N } "Location after turning left while facing east should be north"


    testCase "Turning right while starting facing east now facing south" <| fun _ ->
      let rover' = sendCommand R rover |> sendCommand R

      let loc = rover'.getLoc ()
      
      Expect.equal loc { X = 0; Y = 0; Heading = S } "Location after turning right while facing east should be south"


    testCase "Turning right while starting facing south now facing west" <| fun _ ->
      let rover' = sendCommand R rover |> sendCommand R |> sendCommand R

      let loc = rover'.getLoc ()
      
      Expect.equal loc { X = 0; Y = 0; Heading = W } "Location after turning right while facing south should be west"



    testCase "Turning left while starting facing south now facing east" <| fun _ ->
      let rover' = sendCommand R rover |> sendCommand R |> sendCommand L

      let loc = rover'.getLoc ()
      
      Expect.equal loc { X = 0; Y = 0; Heading = E } "Location after turning left while facing south should be east"
  ]
