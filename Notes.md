# C# Fundamentals -Pluralsight

### Running and Buildng a .NET application

* dotnet restore checks to see if there are any dependencies
* dotnet build then sees the full picture of the application
* C# compiler transforms the source code into binary representation necessary to run the application
* NuGet: package manager for .NET applications (similar to npm for Node)
* DLL file: assembly, output of the compiler that contains the code in binary format
* dotnet is required to run compiled code
  Eg. `dotnet bin\debug\netcoreapp2.1\Gradebook.dll`

**Static**
* Not associated with an object instance, associated with a type
* Be conservative when using this keyword
* Negates the benefit of OOP
* Beneficial to use system-wide classes (i.e. Console, Math, Double)

### Reference vs. Values

**Value Types**
* Value types creates space for the variable, but stores the actual value itself, no reference
* These are integers, floats, doubles

**Reference Types**
* 