# Descrzione

#### Il linguaggio utilizzato in questo codice è il C#

> Per risolovere questo esercizio bisogna superare 15 test.

Data una stringa formata SOLO da cifre, calcolare il prodotto più grande per una sua sottostringa contigua di cifre di lunghezza N.

**Ad esempio:**

- data in ingresso la stringa "1027839564", 
- il prodotto più grande per una serie di 3 cifre è 270 (9 * 5 * 6)
- e il prodotto più grande per una serie di 5 cifre è 7560 (7 * 8 * 3 * 9 * 5).

- Per l'ingresso "73167176531330624919225119674426574742355349194934", il prodotto più grande per una serie di 6 cifre è 23520.

# Descrizione della soluzione

``` 
if (span == 0)
    return 1;
``` 
> Se lo span è 0 il risultato sarà 1 (Esempio = digits: "123"  span:"0" ---> il risultato sarà 1.)

```
if(span<0 || digits=="")
   throw new ArgumentException();
```
> Quando il digits è vuoto, cioè non è composta da nessuna cifra, oppure lo span è negativo, il programma rivela che è stato passato un argomento non valido a un metodo e quindi è inaccettabile: **ArgumentException** (Esempio = digits: "" span: "3" ---> . . . (niente) oppure digits: "123" span: "-2" ---> . . .  (Niente))

```
char[] c = digits.ToCharArray();

for (int i = 0; i < digits.Length; i++)
        {
            if( Char.IsLetter(c[i]))
            {
                throw new ArgumentException();
            }
        }
```
> Questo pezzo di codice serve per verificare che non ci siano lettere nella sequenza di cifre: tramite un for scorriamo la lunghezza di digit e avendo convertito digits in CharArray possiamo sfruttare il metodo "**Char.IsLetter()**" che analizza ogni carattere e controlla se sia una lettera e in caso sia vero invia un **ArgumentException** (Esempio = digits:"1234d" span:"2" ---> . . . )

```
char[] c = digits.ToCharArray();

 for (int i = 0; i < digits.Length; i++)
        {
            if( !Char.IsNumber(c[i]))
            {
                throw new ArgumentException();
            }
        }
 ```
 > Un'alternativa che si poteva fare era che se il digits era diverso da un numero inviava un **ArgumentException**.
 
 ```
 int max = 0;
 
  for (int i = 0; i <= digits.Length - span; i++)
        {
            int prodotto = 1;
            for (int x = i; x < i + span; x++)
            {
                int digit = digits[x] - '0';
                prodotto *= digit;
            }

            if( prodotto > max)
            {
                max = prodotto;
            }
        }
        return max;
 ```
 > Questo pezzo di codice calcola il massimo prodotto di una sequenza di cifre all'interno dell'array "digits" di lunghezza "span".
 > 1. Viene inizializzata una variabile chiamata "max" con il valore di 0 e questa conterrà il massimo prodotto.
 > 2. Viene utilizzato un for che scorre gli elementi dell'array. L'indice va da 0 a "digits.Length - span" e serve per assicurarsi che ci sia abbastanza spazio per formare una sequenza di lunghezza "span" all'interno dell'array.
 > 3. Viene utilizzato un altro for dove viene inizializzata la variabile "prodotto" con il valore 1 che terrà conto del prodotto della sequenza di numeri corrente.
 > 4. L'ultimo for scorre l'array per "span" volte partendo dall'indice e calcola il prodotto della sequenza di "span" cifre. Viene estratto il valore numerico di ogni cifra dall'array e viene moltiplicato con il valore corrente di "prodotto".
 > 5. Viene utilizzato un if per verificare se il prodotto è maggiore di "max" e se è vero il valore di "max" viene aggiornato con il nuovo valore di "prodotto"; alla fine restituisce "max" che è il massimo prodotto.
 
 #### Io sono riuscito a passare 14 test su 15: l'ultimo test che mi mancava era il seguente:
 ```
 if(span > digits.Length)
    throw new ArgumentException();
 ```
 > Nel caso span fosse più grande della lunghezza di "digits" invia un **ArgumentException**. (Esempio = digits:"12" span:"6" ---> . . .)
 
        
      





