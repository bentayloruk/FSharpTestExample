namespace FsharpTestExample

//Code under test is in module Rad.
//Use multiple modules here just for module demo purposes.  Not needed for the tests.
//TestDriven.Net wont run these from file right click, but will from solution right click.


//The awesome Rad module
module Rad = 
    let radify text = text + "rad"

//Tests for it (trad xUnit style)
module RadTestsXunit =
    open Rad
    open Xunit

    [<Fact>]
    let radShouldRadify () =
        Assert.Equal<string>("benrad", radify "ben")
        ()

//Tests for it (FsUnit style)
module RadTestsFsUnit =
    open Rad
    open FsUnit.Xunit
    open Xunit

    [<Fact>]
    let radShouldRadify () =
        radify "ben" |> should equal "benrad"
        ()