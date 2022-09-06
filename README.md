# Projekt-Dokumentation

Koelewijn Keanu

| Datum | Version | Zusammenfassung|
| ----- | ------- | ------------------------------------------------------------ |
|23.08.2022| 0.0.1|Erstes Projekt angefangen, Informierung und Planung wird durchgeführt und dokumentiert.|
|30.08.2022| 0.0.2|Das Programmieren (realisieren) wurde angefangen, Generierung, Auswahl der Zahl wurde erstellt und mögliche Fehleingaben wurden angefangen zu umgehen.|
|06.09.2022 | 0.0.3|Neustart Funktion wurde eingebaut, alle möglichen Fehlereingaben wurden umgangen, Schwierigkeitsgrad wurde hinzugefügt, Startsequenz und Einleitung wurde eingebaut, Programm wurde übersichtlicher gestaltet und die Realisierung wurde abgeschlossen.|


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
| 1.1  |Apk gestartet, zufällige Zahl generiert und wartet auf Eingabe|Gewünschte Zahl wird eingegeben|Sie haben gewonnen|
| 2.1  |Apk gestartet, zufällige Zahl generiert und wartet auf Eingabe|"Buchstabe"|Bitte geben Sie eine gültige Zahl ein|
| 3.1  |Apk gestartet, zufällige Zahl generiert|kleiner Zahl|Sie haben zu tief geschätzt. Versuchen sie es nochmal.|
| 4.1  |Apk gestartet, zufällige Zahl erraten, Wollen sie nochmal spielen?|Ja|Apk wird wiederholt|

### 1.4 Diagramme
![Number Guessing Game noch gegenauer](https://user-images.githubusercontent.com/110892283/186118243-1b8f3061-4e03-4b51-ad8a-db9c58439c1b.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |30.08.2022|Ich|Realisierung wird angefangen, zufällige Zahl wird generiert|30min|
| 1.B  |30.08.2022|Ich|Es wird angezeigt, ob die eingegebene Zahl zu hoch oder zu klein ist.|40min|
| 1.C  |30.08.2022|Ich|Eine Meldung wird angezeigt, wenn man die Zahl erraten hat. |40min|
| 1.D  |30.08.2022|Ich|Das Programm erkennt ungültige Zahlen und reagiert entsprechend darauf.|40min|
| 1.E  |06.09.2022|Ich|Eine Schleife wird erstellt, damit man das Programm wiederholen kann|30min|
| 1.F  |06.09.2022|Ich|Catch und try Funktion, wird bei Fehler eingaben angewendet und das Programm reagiert dementsprechend darauf.|60min|
| 1.G  |06.09.2022|Ich|Restliche Funktionen, die kein Muss sind können, werden eingebaut, wenn Zeit vorhanden ist.|110min|
Total: 300min

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |20.08.2022|ich|4 Arebitspakete|4 Arbeitspakete|
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
