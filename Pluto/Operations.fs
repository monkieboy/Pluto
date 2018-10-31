namespace Exercise

open Types

[<AutoOpen>]
module Operations =
    let landOn(planet) =
        { X = 0; Y = 0; Heading = N; OnPlanet = planet }

