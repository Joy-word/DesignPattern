// See https://aka.ms/new-console-template for more information

using Bridge;

Console.WriteLine("Hello, World!");

//PC lite
BridgeMessager pclite = new BridgeMessagerLite(new BridgePCMessagerBase());
pclite.Login("111","123");

//Mobie perfect
BridgeMessager mobieperfect = new BridgeMessagerPerfect(new BridgeMobieMessagerBase());
mobieperfect.Login("111", "123");