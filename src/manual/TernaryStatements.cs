// Ternary statements into methods.
windowLines = MachineControllerUtils.GetPrimitivesInWorkspace(
    i == 0 ? true : false,         // isfirst
    i < numWindows - 1 ? false : true // islast
);

// You can approach variable assignments as:
double temperature = 20;
String message = (temperature>=15) ? "It's warm outside" : "It's cold outside";
Console.WriteLine(message);
