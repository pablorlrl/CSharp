// String with parameters. $ and @ operators.
this._deleteDesignURL = $"http://{this._settings.DesignServerIpAddress}:{this._settings.DesignServerPort}/design/deleteDesign";
Path.Combine(@"C:\Designs", fileName + ".aps"),

// Text operators

    //@ permits parameters.
    string = $"hello {param}"

    //$ Literal
    string = "C:\Users" // This is not possible because you should use the C# escaping type = "\" being "C:\\Users". or you can do as follows:
    string = @"C:\Users"

    // Both.
    string message = $@"My name is {firstName} {lastName}, and I am {age} years old.";