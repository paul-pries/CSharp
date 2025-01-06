using System;
using System.IO;

// Aufgabe: Berechne den Durchschnitt von vier Zahlen, welche vom Benutzer eingegeben werden

public class Durchschnitt
{
    public static void Main()
    {
        // Deklaration von vier Variablen
        double zahl1, zahl2, zahl3, zahl4;

        // Eingabeaufforderung an Benutzer um die erste Zahl einzugeben
        Console.Write("Gib die erste Zahl an: ");
        // Liest die erste eingegebene Zahl des Benutzers ein und konvertiert diese in den Dateityp double
        zahl1 = Convert.ToDouble(Console.ReadLine());

        // Eingabeaufforderung an Benutzer um die zweite Zahl einzugeben
        Console.Write("Gib die zweite Zahl an: ");
        // Liest die zweite eingegebene Zahl des Benutzers ein und konvertiert diese in den Dateityp double
        zahl2 = Convert.ToDouble(Console.ReadLine());

        // Eingabeaufforderung an Benutzer um die dritte Zahl einzugeben
        Console.Write("Gib die dritte Zahl an: ");
        // Liest die dritte eingegebene Zahl des Benutzers ein und konvertiert diese in den Dateityp double
        zahl3 = Convert.ToDouble(Console.ReadLine());

        // Eingabeaufforderung an Benutzer um die vierte Zahl einzugeben
        Console.Write("Gib die vierte Zahl an: ");
        // Liest die vierte eingegebene Zahl des Benutzers ein und konvertiert diese in den Dateityp double
        zahl4 = Convert.ToDouble(Console.ReadLine());

        // Berechnet den Durchschnitt der vier eingegebenen Zahlen
        double result = (zahl1 + zahl2 + zahl3 + zahl4) / 4;

        // Zeigt den Durchschnitt der vier eingegebenen Zahlen in der Konsole an
        Console.WriteLine("Der Durchschnitt von {0}, {1}, {2}, {3} ist: {4} ",
            zahl1, zahl2, zahl3, zahl4, result);
    }
}