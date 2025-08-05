# Lethal Company Mod Template

This project is a simple template for creating mods for the game Lethal Company. It provides a default setup using BepInEx and Harmony, along with a basic plugin structure to get you started quickly.

## Features
- **BepInEx Integration**: Easily create mods using the BepInEx framework.
- **Harmony Patching**: Apply runtime modifications to the game using Harmony.
- **Configurable Settings**: Enable or disable debug features through configuration.
- **Asset Bundle Support**: Load custom assets into the game.

## Getting Started

### Prerequisites
- **Lethal Company**: Ensure the game is installed on your system.
- **BepInEx**: Install BepInEx in the Lethal Company directory.
- **.NET SDK**: Make sure you have the .NET SDK installed.

### Setup
1. Clone this repository.
2. Open the solution in your preferred IDE.
3. Adjust the paths in `Template.csproj` to match your Lethal Company installation.
4. Build the project using the command:
   ```bash
   dotnet build
   ```
5. Place the compiled DLL in the BepInEx plugins folder.

## License
This project is licensed under the MIT License.

---

This template aims to simplify the process of creating mods for Lethal Company, providing a solid foundation to build upon. Happy modding!