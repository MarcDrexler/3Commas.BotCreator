# 3Commas.BotCreator

This unofficial tool makes it possible to create several simple DCA bots at once.

---

The implementation is based on .Net Framework. I actually wanted to create it with .Net Core, but the View Designer isn't really ready for production yet. I will probably upgrade to .NET 5 in November.
Therefore I created the tool more or less quick & dirty because I needed this functionality quickly. Time was money in this case :)

Implementation is build upon the CryptoExchange.Net, 3Commas.Net and Binance.Net libraries. Thanks for the brilliant work!

I develop and maintain this package on my own for free in my spare time.

The only use cases available are the ones I needed for myself. But if you need something, [let me know](https://github.com/MarcDrexler/3Commas.BotCreator/issues).

Also if you think something is broken or have any questions, please open an [Issue](https://github.com/MarcDrexler/3Commas.BotCreator/issues).



## Features

- Add as many bots you want
- Uses pairs at the highest volume first
- Signals currently available: Manual, Nonstop, TradingView, RSI
- Buys tokens for your new Short bots via market buy order

## Screenshots

![Settings](https://github.com/MarcDrexler/3Commas.BotCreator/blob/master/Settings.png)

![Main Screen](https://github.com/MarcDrexler/3Commas.BotCreator/blob/master/Bot%20Creator.png)

## Prerequisites

- .NET Framework 4.7.2 (which already might be installed on your Windows machine)
- 3Commas API key and secret
- Binance API key and secret

Note: API Keys will never be stored on your machine. They are only available in memory and you have to provide them again next time you start the application.

### Why Binance API Keys?

The App will find suitable Pairs for you. It simply query Binance for pairs and orders them by Volume descending.
If you want to create Short Bots and you don't have tokens for the new pairs, it will automatically buys tokens for you (if you want that).

I might add other exchanges in the future.

## Installer

I use MS ClickOnce for installation and updates.

An installer with the current version is hosted [here](https://marcdrexler.blob.core.windows.net/botcreator/BotCreator.application)

Updates are automatically checked for each start.

## Source

Code will be avilable soon. Only a few days. :-)




