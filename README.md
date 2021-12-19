# HelloWorld (CSharp + VSCode)

## I. Essential

### A. How to Setup?

1. Install `dotnet-sdk` (latest version - 6.0)
    - Homebrew
        - Command: `brew install --cask dotnet-sdk`
        - Verification: `dotnet --version`
        - Reference: [dotnet-sdk](https://formulae.brew.sh/cask/dotnet-sdk#default)

2. (Optional) Install `dotnet-sdk` (old versions - 3.1 / 5.0)
    - `homebrew-dotnet-sdk-versions`: [Runbook](https://github.com/isen-ng/homebrew-dotnet-sdk-versions#installing-one-of-the-versions-here)
        - Commands (Example):
            1. Installation (dotnet-sdk versions tap): `brew tap isen-ng/dotnet-sdk-versions`
            2. Installation (`dotnet 3.1.415`): `brew install --cask dotnet-sdk3-1-400`
            3. Verification (ARM64): `dotnetx64 --list-sdks`

3. Create a new solution.
    - Command: `dotnet new sln --name CSharp.VSCode.HelloWorld`
    - Command (Example): `dotnet new sln --name CSharp.VSCode.HelloWorld`

4. Create a new Console Project (latest version - net6.0).
    - Command: `dotnet new console --name <project-name> --output <folder-path-of-the-project>/<project-name>`
    - Command (Example): `dotnet new console --name CSharp.VSCode.HelloWorld.ConsoleApp.v60 --output src/CSharp.VSCode.HelloWorld.ConsoleApp.v60`.

5. (Optional) Create a new Console Project (old versions - netcoreapp3.1 / net5.0)
    - Prerequiste: `dotnet-sdk` of the associated version has been installed.
    - Command (Example): `dotnetx64 new console --framework netcoreapp3.1 --name CSharp.VSCode.HelloWorld.ConsoleApp.v31 --output src/CSharp.VSCode.HelloWorld.ConsoleApp.v31` 

6. Add the Console Projects into the Solution
    - Command: `dotnet sln <solution-name> add **/*.csproj`
    - Command (Example): `dotnet sln CSharp.VSCode.HelloWorld.sln add **/*.csproj`

### B. How to Build & Run?

1. Build a specific project.
    - Command: `dotnet build <project-path>`
    - Command (Example): `dotnet build src/CSharp.VSCode.HelloWorld.ConsoleApp.v60`

2. Run a specific project. 
    - Command: `dotnet run --project <project-path>`
    - Command (Example): `dotnet run --project src/CSharp.VSCode.HelloWorld.ConsoleApp.v60`

### C. How to Setup & Run Unit Tests?

1. Create a new Unit Testing Project (latest version - 6.0)
    - Command: `dotnet new <unit-test-template> --name <test-project-name> --output <folder-path-of-the-project>/<test-project-name>`
    - Command (Example): `dotnet new xunit --name CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests --output tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests`
    - Examples (Unit Test Template): 
        - `mstest` 
        - `nunit` 
        - `xunit` 

2. Add the Test Project to the Solution
    - Command (Example): `dotnet sln CSharp.VSCode.HelloWorld.sln add tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests/*.csproj`

3. Add a project reference
    - Command (Example): `dotnet add tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests.csproj reference src/CSharp.VSCode.HelloWorld.ConsoleApp.v60/CSharp.VSCode.HelloWorld.ConsoleApp.v60.csproj`
        - Result: The following code block is added into the `tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests.csproj` file.
            ```
            <ItemGroup>
                <ProjectReference Include="..\..\src\CSharp.VSCode.HelloWorld.ConsoleApp.v60\CSharp.VSCode.HelloWorld.ConsoleApp.v60.csproj" />
            </ItemGroup>
            ```

4. Implement a simple logic and a unit test to test that.
    - Example (Implementation): `MathUtil.cs` 
    - Example (Unit Test): `MathUtilTests.cs`
    - Notes:
        - Note that the implementation class should be inside the `CSharp.VSCode.HelloWorld.ConsoleApp.v60` folder and have the `CSharp.VSCode.HelloWorld.ConsoleApp.v60` namespace.
        - Then in the Unit Test class, there must be the `using CSharp.VSCode.HelloWorld.ConsoleApp.v60` statement.

5. Run the Unit Test!
    - Command: `dotnet test <unit-test-csproj>`
    - Command (Example): `dotnet test tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests/CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests.csproj`

## II. Others

### A. Git & README.md

- `README.md` and `.gitignore` need to be created separately.

### B. Extensions 

- C#, By Microsoft (`ms-dotnettools.csharp`)

## III. References

- [Microsoft - .NET - dotnet new](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-new)
- [Microsoft - .NET - dotnet sln](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-sln)
- [Microsoft - .NET - Tutorial: Test a .NET class library using Visual Studio Code](https://docs.microsoft.com/en-us/dotnet/core/tutorials/testing-library-with-visual-studio-code?pivots=dotnet-6-0)