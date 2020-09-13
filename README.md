# 3Commas.BotCreator

Unofficial Tool to bulk create 3commas bots.

This tool makes it possible to create several simple DCA bots at once.

---

Implementation is build upon the CryptoExchange.Net, 3Commas.Net and Binance.Net libraries, make sure to also check out the documentation on that: docs


I develop and maintain this package on my own for free in my spare time.
The only use cases available are those, I needed for myself. But if you need something, [let me know](https://github.com/MarcDrexler/3Commas.BotCreator/issues).
Also if you think something is broken or have any questions, please open an [Issue](https://github.com/MarcDrexler/3Commas.BotCreator/issues).


![Screenshot](https://github.com/MarcDrexler/3Commas.BotCreator/blob/master/Bot%20Creator.png)


## Prerequisites

- .NET Framework 4.7.2 (which already might be installed on your Windows machine)
- 3Commas API key and secret
- Binance API key and secret

### Why Binance API Keys?

The App will find suitable Pairs for you. It simply query Binance for pairs and orders them by Volume descending.
If you want to create Short Bots and you don't have tokens for the new pairs, it will automatically buys tokens for you (if you want that).

I might add other exchanges in the future.
