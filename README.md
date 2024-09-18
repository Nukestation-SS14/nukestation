<img src="./Resources/Textures/Logo/splashlogo.png">

---

Nukestation is a codebase for SS14, forked from [Einstein Engines](https://github.com/Simple-Station/Einstein-Engines), which is a hard fork of the original [Space Station 14](https://github.com/space-wizards/space-station-14) code (commonly refered to as "Wizden").

Space Station 14 is inspired heavily by Space Station 13 and runs on [Robust Toolbox](https://github.com/space-wizards/RobustToolbox), a homegrown engine written in C#.

As a hard fork, any code sourced from a different upstream cannot ever be merged directly here, and must instead be ported.
All code present in this repository is subject to change as desired by the council of maintainers.

## Official Server Policy

Official servers for Nukestation are run by Emmaker, on [Networkgamez](https://networkgamez.com) and are broadcasted to the WizDen and Multiverse hubs.

## Links

[Steam(SSMV Launcher)](https://store.steampowered.com/app/2585480/Space_Station_Multiverse/) | [Steam(WizDen Launcher)](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Standalone](https://spacestationmultiverse.com/downloads/)

## Contributing

We are happy to accept contributions from anybody, come join our Discord if you want to help. You are also encouraged to contribute to [Einstein Engines](https://github.com/Simple-Station/Einstein-Engines), our upstream repository.

## Building

Refer to [the Space Wizards' guide](https://docs.spacestation14.com/en/general-development/setup/setting-up-a-development-environment.html) on setting up a development environment for general information, but keep in mind that Einstein Engines is not the same and many things may not apply.
We provide some scripts shown below to make the job easier.

### Build dependencies

> - Git
> - .NET SDK 8.0.100


### Windows

> 1. Clone this repository
> 2. Run `git submodule update --init --recursive` in a terminal to download the engine
> 3. Run `Scripts/bat/buildAllDebug.bat` after making any changes to the source
> 4. Run `Scripts/bat/runQuickAll.bat` to launch the client and the server
> 5. Connect to localhost in the client and play

### Linux

> 1. Clone this repository
> 2. Run `git submodule update --init --recursive` in a terminal to download the engine
> 3. Run `Scripts/sh/buildAllDebug.sh` after making any changes to the source
> 4. Run `Scripts/sh/runQuickAll.sh` to launch the client and the server
> 5. Connect to localhost in the client and play

### MacOS

> I don't know anybody using MacOS to test this, but it's probably roughly the same steps as Linux

## License

Please read the [LEGAL.md](./LEGAL.md) file for information on the licenses of the code and assets in this repository.
