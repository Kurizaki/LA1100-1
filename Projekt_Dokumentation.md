# Projekt-Dokumentation

Koelewijn Keanu

| Datum | Version | Zusammenfassung|
| ----- | ------- | ------------------------------------------------------------ |
|23.08.2022| 0.0.1|Erstes Projekt angefangen, Informierung und Planung wird durchgeführt und dokumentiert.|
|30.08.2022| 0.0.2|(User Sotries 5-11) Das Programmieren (realisieren) wurde angefangen, Generierung, Auswahl der Zahl wurde erstellt und mögliche Fehleingaben wurden angefangen zu umgehen.|
|06.09.2022 | 0.0.3|(User Stories 1-4, 12-13) Neustart Funktion wurde eingebaut, alle möglichen Fehlereingaben wurden umgangen, Schwierigkeitsgrad wurde hinzugefügt, Startsequenz und Einleitung wurde eingebaut, Programm wurde übersichtlicher gestaltet und die Realisierung wurde abgeschlossen.|


## 1 Informieren

### 1.1 Ihr Projekt

Ich möchte ein Number Guesser Spiel in C# erstellen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
|1| Kann |Qualität| Als ein Spieler möchte ich eine Startsequenz erhalten, wenn ich das Programm starte.|
|2| Kann|Qualität| Als ein Spieler möchte ich eine Spielerklärung erhalten, wenn ich das Programm starte.|
|3| Kann|Qualität| Als ein Spieler möchte ich ein übersichtliches Spiel haben.|
|4| kann |Funktional|Als ein Spieler möchte ich einen Schwierigkeitsgrad einstellen können|
|5| Muss |Funktional| Als ein Spieler möchte ich eine zufällige Zahl generieren, damit ich sie erraten kann.|
|6| Muss|Funktional|Als ein Spieler möchte ich nur eine Zahl eingeben können, damit ich das Spiel fortsetzen kann.|
|7| Muss|Funktional|Als ein Spieler möchte ich darauf hingewiesen werden, wenn die gewünschte Zahl nicht erreicht wird.|
|8| Muss|Funktional|Als ein Spieler möchte ich darauf hingewiesen werden, wenn ich eine Fehleingabe getätigt habe.|
|9| Muss|Funktional|Als ein Spieler möchte ich angezeigt werden, ob meine Schätzung zu hoch war oder nicht.|
|10| Muss|Funktional|Als ein Spieler möchte ich mehrere Schätzungen eingeben können.|
|11| Muss|Funktional|Als ein Spieler möchte ich angezeigt werden, das meine Schätzung richtig war |
|12| Kann|Funktional|Als ein Spieler möchte ich die Möglichkeit haben, das Spiel neu starten zu können, damit ich das Programm nicht erneut ausführen muss.|
|13| Kann|Qualität|Als ein Spieler möchte ich, das nach dem Neustart nicht die ganze Startsequenz wiederholt wird.|

### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |Programm wird gestartet||Startsequenz wird eingeleitet|
| 2.2  |Startsequenz wurde durchgeführt|Beliebige Taste|Spiel-Erklärung wird angezeigt|
| 3.3  |Spielerklärung wurden angezeigt|Beliebige Taste|Schwierigkeitsgrad Eingabe wird angezeigt|
|4.4 |Schwierigkeitsgrad Eingabe wird angezeigt|1-3|Schwierigkeitsgrad wird gespeichert und spiel wird in dementsprechende Schwierigkeit ausgeführt|
|4.5 |Schwierigkeitsgrad Eingabe wird angezeigt|Ungültige Zahl oder Buchstabe|"Ungültige Zahl" wird angezeigt, bis eine Zahl zwischen 1 und 3 eingegeben wird.|
|5.6 |Spiel wird gestartet||Zufällige Zahl wird automatisch je nach Schwierigkeit generiert|
|6.7 |Spiel wird gestartet|Zufällige Zahl|Spiel wird fortgesetzt|
|7.8 |Zufällige Zahl wird eingegeben|Zufällige Zahl|Es wird darauf hingewiesen, ob die eingegebene Zahl die gewünschte Zahl ist oder nicht.|
|8.9 |Fehlereingabe wird eingegeben|Buchstabe oder ungültige Zahl|Es wird darauf hingewiesen und das Spiel wird fortgesetzt|
|9.10 |Zufällige Zahl wird eingegeben|Zufällige Zahl|Wenn die Zahl grösser oder kleiner als die generierte Zahl ist, wird das ausgegeben|
|10.11 |Zufällige Zahl wird eingegeben|Zufällige Zahl|Der Vorgang wird wiederholt und man kann erneut eine Zahl eingeben.|
|11.12 |Generierte Zahl wird eingegeben|Generierte Zahl|Es wird angezeigt das der Spieler gewonnen hat und wie viele versuche er gebraucht hat.|
|12.13 |Generierte Zahl wurde eingegeben||Man kann das Spiel wiederholen mit Ja oder Nein|
|13.14 |Generierte Zahl wird eingegeben und es wird angezeigt, ob man Neustarten möchte|Ja/Nein|Spiel wird neu gestartet ohne Startsequenz und Spiel-Erklärung|

### 1.4 Diagramme
![Number Guessing Game noch gegenauer](https://user-images.githubusercontent.com/110892283/186118243-1b8f3061-4e03-4b51-ad8a-db9c58439c1b.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |30.08.2022|Keanu Koelewijn|Realisierung wird angefangen, zufällige Zahl wird generiert|30min|
| 1.B  |30.08.2022|Keanu Koelewijn|Es wird angezeigt, ob die eingegebene Zahl zu hoch oder zu klein ist.|40min|
| 1.C  |30.08.2022|Keanu Koelewijn|Eine Meldung wird angezeigt, wenn man die Zahl erraten hat. |40min|
| 1.D  |30.08.2022|Keanu Koelewijn|Das Programm erkennt ungültige Zahlen und reagiert entsprechend darauf.|40min|
| 1.E  |06.09.2022|Keanu Koelewijn|Eine Schleife wird erstellt, damit man das Programm wiederholen kann|30min|
| 1.F  |06.09.2022|Keanu Koelewijn|Catch und try Funktion, wird bei Fehler eingaben angewendet und das Programm reagiert dementsprechend darauf.|60min|
| 1.G  |06.09.2022|Keanu Koelewijn|Restliche Funktionen, die kein Muss sind können, werden eingebaut, wenn Zeit vorhanden ist.|60min|

Total: 300min

## 3 Entscheiden

Während der Realisierung wurden folgende User Stories ausgedacht und hinzugefügt (1-4 und 12.13)

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |30.08.2022|Keanu Koelewijn|30min|20min|
| 1.B  |30.08.2022|Keanu Koelewijn|40min|35min|
| 1.C  |30.08.2022|Keanu Koelewijn|40min|45min|
| 1.D  |30.08.2022|Keanu Koelewijn|40min|35min|
| 1.E  |06.09.2022|Keanu Koelewijn|30min|20min|
| 1.F  |06.09.2022|Keanu Koelewijn|60min|50min|
| 1.G  |06.09.2022|Keanu Koelewijn|60min|80min|

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 2.2  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 3.3  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 4.4  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 4.5  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 5.6  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 6.7  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 7.8  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 8.9  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 9.10  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 10.11  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 11.12  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 12.13  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 13.14  |13.09.2022|Funktioniert|Keanu Koelewijn|
| 14.15  |13.09.2022|Funktioniert|Keanu Koelewijn|

Alle Tests wurde erfolgreich abgeschlossen, Das Proframm läuft einwandfrei.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
