# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

# EasyMapTestRust Development Guidelines

## Project Overview
EasyMapTestRust is a Windows Forms application designed to help Rust game server administrators manage and test custom map files. Key features include:

- Monitoring map directory for changes using FileSystemWatcher
- Creating server start files (.bat) for launching Rust servers with specific maps
- Downloading and installing SteamCMD for server management
- Downloading Rust server files (main and beta branches)
- Providing desktop notifications for map changes
- Supporting drag and drop for map files
- Tracking history of previously used maps
- Managing client map files

## Technical Architecture
- **UI Framework**: Windows Forms with Bunifu UI controls
- **Target Framework**: .NET Framework 4.8
- **Dependency Management**: NuGet with Costura.Fody for embedding dependencies
- **Serialization**: Newtonsoft.Json and System.Text.Json
- **HTTP Client**: RestSharp
- **Logging**: Custom debounced logging system to prevent log spam
- **Settings**: Application settings persisted using .NET Settings API

## Build & Run Commands
- Build project: `msbuild EasyMapTestRust.sln /p:Configuration=Debug`
- Run application: `./EasyMapTestRust/bin/Debug/EasyMapTestRust.exe`
- Clean project: `msbuild EasyMapTestRust.sln /t:Clean`
- Package release: `msbuild EasyMapTestRust.sln /p:Configuration=Release`

## Key Source Files
- **MainForm.cs**: Main application window with all core functionality
- **Program.cs**: Application entry point
- **debouncelog.cs**: Implementation of debounced logging for handling frequent messages

## Code Style Guidelines
- **Imports**: Group by namespace, System.* first, third-party libraries next, project namespaces last
- **Naming**: PascalCase for class/method names, camelCase for variables, _camelCase for private fields
- **Formatting**: Braces on new lines, 4-space indentation, explicit access modifiers
- **Regions**: Use #region to group related functionality
- **Error Handling**: Use try-catch blocks with specific exceptions and HandleError method
- **Async**: Use async/await for all asynchronous operations, avoid .Result or .Wait()
- **UI Patterns**: Use Invoke for cross-thread UI updates, implement proper UI feedback during operations
- **File Operations**: Always handle IOException/UnauthorizedAccessException when working with files
- **Logging**: Use LogMixed method for general logging, LogMixedDebounced for frequent messages

## Process Management
- Process output from external tools (like SteamCMD) is captured and debounced using the SetupProcessOutputHandlers method
- Cross-thread UI updates are handled using Control.Invoke pattern