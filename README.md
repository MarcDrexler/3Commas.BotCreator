# 3Commas.BotCreator

This unofficial tool makes it possible to create several simple DCA bots at once.

---

The implementation is based on .Net Framework. I actually wanted to create it with .Net Core, but the View Designer isn't really ready for production yet. I will probably upgrade to .NET 5 in November.
Therefore I created the tool more or less quick & dirty because I needed this functionality quickly. Time was money in this case :)

Implementation is build upon the CryptoExchange.Net, 3Commas.Net, Binance.Net and Huobi.Net libraries. Thanks for the brilliant work!

The only use cases available are the ones I needed for myself. But if you need something, [let me know](https://github.com/MarcDrexler/3Commas.BotCreator/issues).

Also if you think something is broken or have any questions, please open an [Issue](https://github.com/MarcDrexler/3Commas.BotCreator/issues).

## Features

- Add as many bots you want
- Uses pairs at the highest volume first
  - If there is an existing bot with the name of the new bot, it will be skipped.
    This way you can create 10 Bots, and another day the next 10 Bots without having to worry about duplicates.
    You can specify your own name schema. There are existing placeholders for Strategy and Pair.
- Signals currently available: Manual, Nonstop, TradingView, RSI
- Buys tokens for your new Short bots via market buy order (Binance & Huobi only)

### Excluded Pairs

All pairs that end with UP, DOWN, BEAR, BULL and are skipped.
Also EUR Pairs.

The blacklist is currently hard coded and will be configurable in the future

## Screenshots

![Main Screen](https://github.com/MarcDrexler/3Commas.BotCreator/blob/master/screenshots/Mainscreen.png)

## Prerequisites

- .NET Framework 4.7.2 (which already might be installed on your Windows machine)
- 3Commas API key and secret
- Exchange API key and secret (Binance or Huobi)

Note: API Keys will never be stored on your machine. They are only available in memory and you have to provide them again next time you start the application.

### Why PI Keys for my Exchange?

The App will find suitable Pairs for you. It simply query your Exchange for pairs and orders them by Volume descending.
If you want to create Short Bots and you don't have tokens for the new pairs, it will automatically buys tokens for you (if you want that).

## Installer

I use MS ClickOnce for installation and updates.

An installer with the current version is hosted [here](https://marcdrexler.blob.core.windows.net/botcreator/BotCreator.application)

Updates are automatically checked for each start.

## Support

I develop and maintain this package on my own for free in my spare time.
Donations are greatly appreciated and a motivation to keep improving.

XMR: 89rmrxDAGAWWhSZXhnNf335qYfyXz4vQsNAM1VFSg6Y7Tve9BGF9pwte9ps61E9FY76r4onhWw7e19eu7fM8BARQMRHNBt7

or

<a href="https://www.buymeacoffee.com/marcdrexler" target="_blank"><img width="136" height="40" src="https://cdn.buymeacoffee.com/buttons/v2/default-orange.png" alt="Buy Me A Coffee" style="height: 40px !important;width: 136px !important;" ></a>



