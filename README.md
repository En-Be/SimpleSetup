# Simple Setup

## How to make a simple C# console program

### Installation
- In a bash terminal, run the following commands:

    ```
    wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
    sudo dpkg -i packages-microsoft-prod.deb
    ```

- Then install the dotnet SDK:

    ```
    sudo apt-get update
    sudo apt-get install apt-transport-https
    sudo apt-get update
    sudo apt-get install dotnet-sdk-3.0
    ```

- Then install the testing framework:

    ```
    dotnet add package NUnit --version 3.12.0
    ```
### Setup

- You should now be able to make a new project:

    ```
    dotnet new nunit -o NameOfProject
    ```

- Within the NameOfProject.csproj file, add the following inside the PropertyGroupo tag:

    ```
    <GenerateProgramFile>false</GenerateProgramFile>
    ```
    Without this, the testing files would create a file that clashes with the program we will write.

- Rename the test file:

    ```
    cd NameOfProject
    mv UnitTest1.cs NameOfProjectTest.cs
    ```

- Create a NameOfProject.cs file at project root:

    ```
    touch NameOfProject.cs
    ```
    and fill it with:
    ```
    using System;

    namespace NameOfProject
    {
        class Program
        {
            static void Main(string[] args)
            {
                NameOfProject project = new NameOfProject(args);
            }

        }

        class NameOfProject
        {
            public NameOfProject(string[] args)
            {
                foreach(string arg in args)
                {
                    Console.WriteLine($"Hello there {arg}");
                }
            }
        }
    }
    ```


### Running the project

- To run the project with optional arguments, in the console:

    ```
    dotnet run "You" "Me"
    ```
    prints this:
    ```
    Hello there You
    Hello there Me
    ```

- To run the tests:

    ```
    dotnet test -v n
    ```
    prints this:
    ```
    √ Test1 [40ms]

    √ Test2 [< 1ms]

    Test Run Successful.
    Total tests: 2
        Passed: 2
    Total time: 1.1531 Seconds
        1>Done Building Project "/mnt/c/Users/Nicholas/Projects/Hello/Hello.csproj" (VSTest target(s)).

    Build succeeded.
        0 Warning(s)
        0 Error(s)

    Time Elapsed 00:00:03.01
    ```
    The -v n flag gives us more information on which tests passed and failed.

## The NameOfProject.cs and NameOfProjectTest.cs files are now ready for TDD.