
using System.Collections.Generic;


namespace Oxide.Plugins
{
    [Info("Player Check", "Austin9675", "1.0.0")]
    [Description("Checks usernames for banned words, then renames them if they have any, any request for adding words dm me on discord")]
    class PlayerCheck : RustPlugin
    {
        private int badUserCounter = 0;
        List<string> badNamesList = new List<string> {"nigger", "niglet", "fag", "faggot", "queer", "f@g", "n!663r", "n!66er", "n1gger", "n@gger",
        "n@663r", "f@66ot", "f@660t", "chink", "spook", "spic", "towel head", "terrorist", "childpred", "child sniffer", "melon muncher", "porch monkey",
        "sand nigger", "sand monkey", "lgbtq", "qu33r", "rape", "r@p!st", "r@pe", "r@p3", "rap3", "Spook", "yellow nigger", "nigga", "n!664", "n!66a",
        "n!gga", "mokey lips", "monkey", "baboon"};

        void OnPlayerConnected(BasePlayer player)
        {
            string name = player.displayName;
            string userName = name.ToLower();


            foreach (string badName in badNamesList)
            {
                if (userName.Contains(badName.ToLower()))
                {
                    badUserCounter++;
                    player.displayName = $"Bad Sport #{badUserCounter}";
                    player.ChatMessage("Your name contains a banned word, either change it or remain a bad sport");
                    Puts($"Bad name detected: {name}. Player has been renamed to Bad Sport #{badUserCounter}.");
                }
            }



            Puts($"player name is {userName}");
        }
    }
}