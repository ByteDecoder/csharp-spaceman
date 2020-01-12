using System;

namespace Spaceman {
  public class Ufo {
    private string s0 = "" +
    "                 .                            \n" +
    "                 |                            \n" +
    "              .-\"^\"-.                       \n" +
    "             /_....._\\                       \n" +
    "         .-\"`         `\"-.                  \n" +
    "        (  ooo  ooo  ooo  )                   \n" +
    "         '-.,_________,.-'    ,-----------.   \n" +
    "              /     \\        (  Send help! ) \n" +
    "             /   0   \\      / `-----------'  \n" +
    "            /  --|--  \\    /                 \n" +
    "           /     |     \\                     \n" +
    "          /     / \\     \\                   \n" +
    "         /               \\                   \n";

    private string s1 = "" +
    "                 .                            \n" +
    "                 |                            \n" +
    "              .-\"^\"-.                       \n" +
    "             /_....._\\                       \n" +
    "         .-\"`         `\"-.                  \n" +
    "        (  ooo  ooo  ooo  )                   \n" +
    "         '-.,_________,.-'    ,-----------.   \n" +
    "              /  0  \\        (  Send help! ) \n" +
    "             / --|-- \\      / `-----------'  \n" +
    "            /    |    \\    /                 \n" +
    "           /    / \\    \\                    \n" +
    "          /             \\                    \n" +
    "         /               \\                   \n";

    private string s2 = "" +
    "                 .                            \n" +
    "                 |                            \n" +
    "              .-\"^\"-.                       \n" +
    "             /_....._\\                       \n" +
    "         .-\"`         `\"-.                  \n" +
    "        (  ooo  ooo  ooo  )                   \n" +
    "         '-.,_________,.-'    ,-----------.   \n" +
    "              /--|--\\        (  Send help! ) \n" +
    "             /   |   \\      / `-----------'  \n" +
    "            /   / \\   \\    /                \n" +
    "           /           \\                     \n" +
    "          /             \\                    \n" +
    "         /               \\                   \n";

    private string s3 = "" +
    "                 .                            \n" +
    "                 |                            \n" +
    "              .-\"^\"-.                       \n" +
    "             /_....._\\                       \n" +
    "         .-\"`         `\"-.                  \n" +
    "        (  ooo  ooo  ooo  )                   \n" +
    "         '-.,_________,.-'    ,-----------.   \n" +
    "              /  |  \\        (  Send help! ) \n" +
    "             /  / \\  \\      / `-----------' \n" +
    "            /         \\    /                 \n" +
    "           /           \\                     \n" +
    "          /             \\                    \n" +
    "         /               \\                   \n";

    private string s4 = "" +
    "                 .                            \n" +
    "                 |                            \n" +
    "              .-\"^\"-.                       \n" +
    "             /_....._\\                       \n" +
    "         .-\"`         `\"-.                  \n" +
    "        (  ooo  ooo  ooo  )                   \n" +
    "         '-.,_________,.-'    ,-----------.   \n" +
    "              / / \\ \\        (  Send help! )\n" +
    "             /       \\      / `-----------'  \n" +
    "            /         \\    /                 \n" +
    "           /           \\                     \n" +
    "          /             \\                    \n" +
    "         /               \\                   \n";

    private string s5 = "" +
    "                 .                            \n" +
    "                 |                            \n" +
    "              .-\"^\"-.                       \n" +
    "             /_....._\\                       \n" +
    "         .-\"`         `\"-.                  \n" +
    "        (  ooo  ooo  ooo  )                   \n" +
    "         '-.,_________,.-'    ,-----------.   \n" +
    "              /     \\        (  Send help! ) \n" +
    "             /       \\      / `-----------'  \n" +
    "            /         \\    /                 \n" +
    "           /           \\                     \n" +
    "          /             \\                    \n" +
    "         /               \\                   \n";
    private readonly string[] ufos;
    private int _stage;

    public Ufo() {
      ufos = new string[] { s0, s1, s2, s3, s4, s5 };
    }

    public void AddPart() {
      _stage++;
      if(_stage >= ufos.Length) {
        _stage = ufos.Length;
      }
    }

    public string Stringify() {
      return ufos[_stage];
    }
  }
}