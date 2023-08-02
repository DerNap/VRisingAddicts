# VRisingAddicts
[VRisingAddicts](https://github.com/DerNap/VRisingAddicts) is my selection of mods 
for V-Rising, mostly updated stuff from projects no longer maintained by the original 
author and therefore no longer working with the latest game patches.
Actually I only do it for mods I am using on my own server.

## List of mods updated for Gloomrot
* [NoGameCursor](#nogamecursor)

## General mod info (Applies to most mods)
* Check out the other readme's in their respective folders for more info

### How to manually install
* Install [BepInEx](https://v-rising.thunderstore.io/package/BepInEx/BepInExPack_V_Rising/)
* Install [Bloodstone](https://v-rising.thunderstore.io/package/deca/Bloodstone/)
* (Locally hosted games only) Install [ServerLaunchFix](https://v-rising.thunderstore.io/package/Mythic/ServerLaunchFix/)
* Extract the VRising._mod-name_.dll
* Move the desired mod(s) to the `[VRising (server) folder]/BepInEx/Plugins/`
* Launch the server (or game) to auto-generate the config files
* Edit the configs as you desire (found in `[VRising (server) folder]/BepInEx/config/`)

# NoGameCursor
This mod is based on [ACPs](https://v-rising.thunderstore.io/package/ACP/NoGameCursor/) mod that stopped working for me after the Gloomrot update.

A mod that change the game cursor to fit your operating system cursor.

<details>

Q: Why would you want that?
A: Well, in a game that heavily relies on the mouse location for aiming, you need to make sure to be able to see the cursor at any time. 
Unfortunaltely the pace of the game and the fast changing graphics often make you lose track of the current mouse location.
Further more the game cursor is fix and can't be customized by the game, but the desktop cursor can. 
With this mod you can disable the game cursor and use any customized Windows cursor or even use tools like YoloMouse.

Q: What is Yolomouse
A:  is a tool to switch the mouse cursor based on the application currently running in foreground. This
allows you to have different mouse cursor designs which are only visible if you really use the configured application.
You could therefore have a really huge cursor that you will never ever lose track only while playing a certain game, e.g. VRising.

Q: Where can I get YoloMouse
A: The newest version can be downloaded from [here](https://pandateemo.github.io/YoloMouse/).
Personally I recommend the fully working older version 0.11.3 since it is fully free of charge, which you can download [here](https://github.com/PandaTeemo/YoloMouse/releases/download/0.11.3/YoloMouse64.msi)

### Screenshots
<details>
<summary>Default Windows 11 cursor</summary>
![Default Windows 11 cursor](https://i.imgur.com/hPcEqZV.png)
</details>

<details>
<summary>Default Windows 11 cursor with custom color</summary>

![Default Windows 11 cursor with custom color](https://i.imgur.com/rxbHpNW.png)

</details>

<details>
<summary>Default Windows 11 cursor in Build Mode</summary>

![Default Windows 11 cursor in Build Mode](https://i.imgur.com/3ReafZw.png)

</details>

### Installation
- Install [BepInExPack V Rising](https://v-rising.thunderstore.io/package/BepInEx/BepInExPack_V_Rising/)
- Extract _NoGameCursor.dll_ into _(VRising folder)/BepInEx/plugins_

### Support
- Raise an issue on [Github](https://github.com/DerNap/VRisingAddicts).

### Changelog
`1.0.0` First release

</details>

## Developer & credits
<details>

### V rising modding discord [Discord](https://discord.gg/XY5bNtNm4w)
### Current Developer
- [DerNap](https://github.com/DerNap)

### Original Creator & Developer
- [ACS](https://v-rising.thunderstore.io/package/ACP/NoGameCursor/)

</details>