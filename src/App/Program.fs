open System
open Library

[<EntryPoint>]
let main args =
    printfn "Nice command-line arguments! Here's what System.Text.Json has to say about them:"

    let value , json = getJson {| args=args; year=System.DateTime.Now.Year |}
    printfn $"Input: %0A{value}"
    printfn $"Output: %s{json}"

    // --------------- Strings --------------- //
    // Using a verbatim string
    let xmlFragment1 : string = @"<book author=""Milton, John"" title=""Paradise Lost"">"
    Console.WriteLine xmlFragment1

    // Using a triple-quoted string
    let xmlFragment2 : string = """<book author="Milton, John" title="Paradise Lost">"""
    printfn "%s" xmlFragment2

    // Break lines and slicing
    let breakLineString1 : string = "Hello
    Sergio"
    printfn "%s" breakLineString1
    printfn "%s" breakLineString1[0..2]

    let breakLineString2 : string = "Hello\
    Sergio"
    printfn "%s" breakLineString2
    printfn "%c" breakLineString2[1]

    // String representation
    
    // "abc" interpreted as a Unicode string.
    let str1 : string = "abc"
    printfn "%s" str1

    // "abc" interpreted as an ASCII byte array.
    let bytearray : byte[] = "abc"B
    Console.WriteLine str1

    // Concat strings
    let concatStrings: string = "Hello, " + "world"
    Console.WriteLine concatStrings

    let printChar (str : string) (index : int) =
        printfn "Character: %c" (str.Chars(index))

    printChar concatStrings 0

    // Interpolated strings
    let name = "Phillip"
    let age = 30
    printfn $"Name: {name}, Age: {age}"
    printfn $"Name: %s{name}, Age: %d{age}"
    // printfn $"Name: %s{age}, Age: %d{name}" // Error!!
    printfn $"""Name: {"Phillip"}, Age: %d{age}"""

    printfn $"I think {3.0 + 0.14} is close to {System.Math.PI}!"

    printfn $"A pair of braces: {{}}"

    // Formats
    let pi = $"%0.3f{System.Math.PI}"  // "3.142"
    let code = $"0x%08x{43962}"  // "0x0000abba"
    let data = [0..4]
    let output = $"The data is %A{data}"  // "The data is [0; 1; 2; 3; 4]"
    let pi = $"{System.Math.PI:N4}"  // "3.1416"
    let now = $"{System.DateTime.UtcNow:``yyyyMMdd``}" // e.g. "20220210"
    let nowDashes = $"{System.DateTime.UtcNow:``yyyy-MM-dd``}" // e.g. "2022-02-10"

    // Aligning expressions in interpolated strings
    printfn $"""|{"Left",-7}|{"Right",7}|"""

    // Aligning expressions in interpolated strings
    let speedOfLight = 299792.458
    printfn $"The speed of light is {speedOfLight:N3} km/s."
    // "The speed of light is 299,792.458 km/s."

    let frmtStr = $"The speed of light is {speedOfLight:N3} km/s." : FormattableString
    // Type: FormattableString
    // The speed of light is 299,792.458 km/s.

    // ## Values

    // ### Binding a Value

    0 // return an integer exit code
