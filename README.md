# Sortieralgorithmen
## Dei Algorithmen
### BubbleSort
In der Bubble-Phase wird die Eingabe-Liste von links nach rechts durchlaufen. Dabei wird in jedem Schritt das aktuelle Element mit dem rechten Nachbarn verglichen. Falls die beiden Elemente das Sortierkriterium verletzen, werden sie getauscht. Am Ende der Phase steht bei auf- bzw. absteigender Sortierung das größte bzw. kleinste Element der Eingabe am Ende der Liste.

Die Bubble-Phase wird solange wiederholt, bis die Eingabeliste vollständig sortiert ist. Dabei muss das letzte Element des vorherigen Durchlaufs nicht mehr betrachtet werden, da die restliche zu sortierende Eingabe keine größeren bzw. kleineren Elemente mehr enthält.

Je nachdem, ob auf- oder absteigend sortiert wird, steigen die größeren oder kleineren Elemente wie Blasen im Wasser (daher der Name) immer weiter nach oben, das heißt, an das Ende der Liste. Es werden stets zwei Zahlen miteinander in „Bubbles“ vertauscht. 

Um die Darstellung des Algorithmus nicht künstlich zu verkomplizieren, wird im Folgenden als Vergleichsrelation > {\displaystyle >} > (größer als) verwendet. Wie bei jedem auf Vergleichen basierenden Sortierverfahren kann diese auch durch eine andere Relation ersetzt werden, die eine totale Ordnung definiert.

Der Algorithmus in seiner einfachsten Form als Pseudocode:

```csharp
bubbleSort(Array A)
  for (n=A.size; n>1; --n){
    for (i=0; i<n-1; ++i){
      if (A[i] > A[i+1]){
        A.swap(i, i+1)
      } // Ende if
    } // Ende innere for-Schleife
  } // Ende äußere for-Schleife
```

Die Eingabe ist in einem Array gespeichert. Die äußere Schleife verringert schrittweise die rechte Grenze für die Bubble-Phase, da nach jedem Bubblen an der rechtesten Position das größte Element der jeweils unsortierten Rest-Eingabe steht. In der inneren Schleife wird der noch nicht sortierte Teil des Feldes durchlaufen. Dabei werden zwei benachbarte Daten vertauscht, wenn sie in falscher Reihenfolge sind (also das Sortierkriterium verletzen).

Allerdings nutzt diese einfachste Variante nicht die Eigenschaft aus, dass nach einer Iteration, in der keine Vertauschungen stattfanden, auch in den restlichen Iterationen keine Vertauschungen mehr stattfinden. Der folgende Pseudocode berücksichtigt dies:

```csharp
bubbleSort2(Array A)
  n = A.size
  do{
    swapped = false
    for (i=0; i<n-1; ++i){
      if (A[i] > A[i+1]){
        A.swap(i, i+1)
        swapped = true
      } // Ende if
    } // Ende for
    n = n-1
  } while (swapped)
  ```

Die äußere Schleife durchläuft die zu sortierenden Daten, bis keine Vertauschungen mehr notwendig sind.

Eine weitere Optimierung besteht in der Ausnutzung der Eigenschaft, dass am Ende einer äußeren Iteration alle Elemente rechts von der letzten Tauschposition schon an ihrer endgültigen Position stehen:

```csharp
bubbleSort3(Array A)
  n = A.size
  do{
    newn = 1
    for (i=0; i<n-1; ++i){
      if (A[i] > A[i+1]){
        A.swap(i, i+1)
        newn = i+1
      } // ende if
    } // ende for
    n = newn
  } while (n > 1)
  ```

#### Beispiel

Eine Reihe von fünf Zahlen soll aufsteigend sortiert werden.

Die fett gedruckten Zahlen werden jeweils verglichen. Ist die linke größer als die rechte, so werden beide vertauscht; das Zahlenpaar ist dann blau markiert. Im ersten Durchlauf wandert somit die größte Zahl ganz nach rechts. Der zweite Durchlauf braucht somit die letzte und vorletzte Position nicht mehr zu vergleichen. → Dritter Durchlauf: kein Vergleich letzte/vorletzte/vorvorletzte…

```
55 07 78 12 42   1. Durchlauf
07 55 78 12 42
07 55 78 12 42
07 55 12 78 42   Letzter Vergleich
07 55 12 42 78   2. Durchlauf
07 55 12 42 78
07 12 55 42 78   Letzter Vergleich
07 12 42 55 78   3. Durchlauf
07 12 42 55 78   Letzter Vergleich
07 12 42 55 78   4. Durchlauf + Letzter Vergleich
07 12 42 55 78   Fertig sortiert. 
```
