# Projekt-Dokumentation

Koelewijn Keanu

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|23.08.2022| 0.0.1 |Erstes Projekt angefangen und das Informieren|
|       | ...     |                                                              |
|       | 1.0.0   |                                                              |

## 1 Informieren

### 1.1 Ihr Projekt

Ich möchte ein Number Guessing Spiel in C# erstellen.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    | Muss            |Funktional| Als ein Spieler möchte ich eine zufällige Zahl generieren, damit ich sie erraten kann.|
| 2    | Muss            |Funktional|Als ein Spieler möchte ich nur eine Zahl eingeben können, damit ich das Spiel fortsetzen kann.|
| 3    | Muss            |Funktional| Als ein Spieler möchte ich darauf hingewiesen werden, wenn die gewünschte Zahl nicht erreicht wird.|
| 4    | Kann            |Funktional|Als ein Spieler möchte ich das Spiel neu starten können, damit ich das Programm nicht erneut ausführen muss.|

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
| 1.A  |23.08.2022|Ich|Informierung und Dokumentation|3 Arbeitspakete|
| 1.B  |30.08.2022|Ich|Realisierung wird angefangen|4 Arbeitspakete|
| 1.C  |06.09.2022|Ich|Realisierung wird fortgesetzt, beendet und getestet|4 Arbeitspakete|
| 1.D  |13.09.2022|Ich|Lehrbericht wird bearbeitet und Projektdokumentation wird ergänzt|4 Arbeitspakete|
Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
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
