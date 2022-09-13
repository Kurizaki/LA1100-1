# Lern-Bericht
Keanu Koelewijn

## Einleitung

Wir mussten ein Number Guesser SPiel in C# erstellen und programmieren.

## Was habe ich gelernt?

Ich habe während der Realisierung, vieles neues gelernt, was ich aber am wichtigsten ist, die Try & Catch Funktion und über diese Funktion habe ich mich in diesem Lernbericht fokussiert.

## Beschreibung

Beim Programmieren von meinem Number Guesser Spiel, musste ich mögliche Fehlereingaben beheben. Durch die funktion Try und Catch ist mir dies möglich gewesen. In dem Abschnitt, in der der code ausgeführt wird, werden alle Fehlereingaben oder ähnliches, das das Programm eigentlich zum Abstürzen bringen sollte, sanft abgefangen und mit catch wird dann den dazu geschriebenen code ausgegeben. Also z. B. wird eine Eingabe verlangt und wenn man etwas Ungültiges eingibt wie fünfzehn anstatt 15, dann wird es zum catch weitergeleitet, in dem dann ausgegeben wird "Ungültige Ausgabe". Als ich dann Try und Catch in meinem Programm einfügte wurden diese Fehler behoben, was mir sehr viel geholfen hat. Ich bin froh darüber das herausgefunden zu haben weil ich mir sonst den Kopf weiter zerbrochen hätte.
```csharp

Console.WriteLine("Versuche es doch nochmal");
// Hier ist eine while schleife, damit die eingabe wiederholt wird wenn sie fehlschlägt.
while (KorrekteEingabe == false)
{
    try
    {
        // Hier wird versucht zu konvertieren.
        // Wenn es fehlschlägt, wird es zu catch weitergeleitet.
        schätzen = Convert.ToInt32(Console.ReadLine());
        KorrekteEingabe = true;
    }
    catch
    {
    // Hier wird dann ausgegeben das die EIngabe ungültig ist.
        Console.WriteLine("Ungültige Eingabe");
        KorrekteEingabe = false;
    }
}
KorrekteEingabe = false;
// Das Programm wird fortgesetzt.
```

In der Konsole sieht es so aus:

![ezgif com-gif-maker](https://user-images.githubusercontent.com/110892283/189847182-20199a85-a224-4730-ac24-fb2f81c13f3b.gif)

## Verifikation

* Text Beschreibung = Ich habe meine Problemstellung erklärt und meinen Lösungsweg beschrieben, um das erlernte zu verstehen.
* Try & Catch Code = Hier wird nochmal in der Programmiersprache angezeigt und beschrieben, wie ich das umgesetzt habe.
* Console Gif = In diesem GIF zeige ich noch das Resultat des Codes.


# Reflektion zum Arbeitsprozess

👍 In diesem Projekt gefiel es mir besonders, mit IPERKA zu arbeiten, ich konnte IPERKA gut nutzen, um eine Übersicht über das Projekt zu haben. Die Planung und das Informieren machte Spass, sich selber Ziele zu setzen, was man erreichen will und was nicht. Beim Realisieren, war ich verwundert, wie ich plötzlich fast den ganzen Code geschrieben hatte, ohne etwas nachzusehen oder mich im Internet zu informieren. Ich hatte das Gefühl, dass meine Überlegungen direkt so wie ich es wollte, in den Code übertragen wurde. Dieses Gefühl gefällt mir und dieser Konzentrationszustand hat mir sehr weitergeholfen in meinem Projekt.

👎 Der Anfang fiel mir am schwersten, zuerst darauf zu kommen, wie ich es umsetzen möchte, wie ich die ersten Bausteine setze. Die Übersicht im Code zu behalten und die Klammern richtig zu setzen, fiel mir manchmal schwer. Als der Code beinahe fertig war, hatte ich das Gefühl den Code zu unübersichtlich geschrieben zu haben, was mich ärgert.

**VBV**: Ich möchte beim nächsten Mal meinen Code übersichtlicher schreiben und einteilen, damit er besser zum ansehen und verstehen ist. Indem ich immer bevor ich den Code fertigstelle, nochmal darüber gehe und ihn schön übersichtlich schreib, evtl. auch Refactoring anwenden.

