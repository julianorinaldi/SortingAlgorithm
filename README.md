# SortingAlgorithm

## Algorítimos de Ordenação

### **Insertion Sort**

> Insertion Sort, ou ordenação por inserção, é o algoritmo de ordenação que, dado uma estrutura (array, lista) constrói uma matriz final com um elemento de cada vez, uma inserção por vez. Assim como algoritmos de ordenação quadrática, é bastante eficiente para problemas com pequenas entradas, sendo o mais eficiente entre os algoritmos desta ordem de classificação.

> Podemos fazer uma comparação do Insertion Sort com o modo de como algumas pessoas organizam um baralho num jogo de cartas. Imagine que você está jogando cartas. Você está com as cartas na mão e elas estão ordenadas. Você recebe uma nova carta e deve colocá-la na posição correta da sua mão de cartas, de forma que as cartas obedeçam a ordenação.

> A cada nova carta adicionada à sua mão de cartas, a nova carta pode ser menor que algumas das cartas que você já tem na mão ou maior, e assim, você começa a comparar a nova carta com todas as cartas na sua mão até encontrar sua posição correta. Você insere a nova carta na posição correta, e, novamente, sua mão é composta de cartas totalmente ordenadas. Então, você recebe outra carta e repete o mesmo procedimento. Então outra carta, e outra, e assim por diante, até você não receber mais cartas.

> Esta é a ideia por trás da ordenação por inserção. Percorra as posições do array, começando com o índice 1 (um). Cada nova posição é como a nova carta que você recebeu, e você precisa inseri-la no lugar correto no subarray ordenado à esquerda daquela posição.

[Referências - Wikipedia](https://pt.wikipedia.org/wiki/Insertion_sort)

Veja o exemplo, muito bem feito, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/ROalU379l3U/0.jpg)](https://youtu.be/ROalU379l3U)

__________

### **Selection Sort**

 > A ordenação por seleção é um algoritmo de ordenação baseado em se passar sempre o menor valor do vetor para a primeira posição (ou o maior dependendo da ordem requerida), depois o de segundo menor valor para a segunda posição, e assim é feito sucessivamente com os n-1 elementos restantes, até os últimos dois elementos.

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Selection_sort)

Veja o exemplo, muito bem feito, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/Ns4TPTC8whw/0.jpg)](https://youtu.be/Ns4TPTC8whw)

__________

### **Quick Sort**

 > O algoritmo quicksort é um método de ordenação muito rápido e eficiente, inventado por C.A.R. Hoare em 1960, quando visitou a Universidade de Moscovo como estudante. Naquela época, Hoare trabalhou em um projeto de tradução de máquina para o National Physical Laboratory. Ele criou o quicksort ao tentar traduzir um dicionário de inglês para russo, ordenando as palavras, tendo como objetivo reduzir o problema original em subproblemas que possam ser resolvidos mais fácil e rápido. Foi publicado em 1962 após uma série de refinamentos.

> O quicksort adota a estratégia de divisão e conquista. A estratégia consiste em rearranjar as chaves de modo que as chaves "menores" precedam as chaves "maiores". Em seguida o quicksort ordena as duas sublistas de chaves menores e maiores recursivamente até que a lista completa se encontre ordenada. Os passos são:

1. Escolha um elemento da lista, denominado pivô;
1. Particiona: rearranje a lista de forma que todos os elementos anteriores ao pivô sejam menores que ele, e todos os elementos posteriores ao pivô sejam maiores que ele. Ao fim do processo o pivô estará em sua posição final e haverá duas sub listas não ordenadas. Essa operação é denominada partição;
1. Recursivamente ordene a sub lista dos elementos menores e a sub lista dos elementos maiores;

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Quicksort)

Veja o exemplo, muito bem feito, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/ywWBy6J5gz8/0.jpg)](https://youtu.be/ywWBy6J5gz8)

__________

### **Merge Sort**

 > O merge sort, ou ordenação por mistura, é um exemplo de algoritmo de ordenação por comparação do tipo dividir-para-conquistar.

>Sua ideia básica consiste em dividir (o problema em vários subproblemas e resolver esses subproblemas através da recursividade) e conquistar (após todos os subproblemas terem sido resolvidos ocorre a conquista que é a união das resoluções dos subproblemas). Como o algoritmo Merge Sort usa a recursividade, há um alto consumo de memória e tempo de execução, tornando esta técnica não muito eficiente em alguns problemas

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Merge_sort)

Veja o exemplo, muito bem feito, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/XaqR3G_NVoo/0.jpg)](https://youtu.be/XaqR3G_NVoo)

__________

### **Shell Sort**

 > Criado por Donald Shell em 1959, publicado pela Universidade de Cincinnati, Shell sort é o mais eficiente algoritmo de classificação dentre os de complexidade quadrática. É um refinamento do método de inserção direta. O algoritmo difere do método de inserção direta pelo fato de no lugar de considerar o array a ser ordenado como um único segmento, ele considera vários segmentos sendo aplicado o método de inserção direta em cada um deles. Basicamente o algoritmo passa várias vezes pela lista dividindo o grupo maior em menores. Nos grupos menores é aplicado o método da ordenação por inserção. 

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Shell_sort)

Veja o exemplo, muito bem feito, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/CmPA7zE8mx0/0.jpg)](https://youtu.be/CmPA7zE8mx0)

__________

### **Bubble Sort**

 > O bubble sort, ou ordenação por flutuação (literalmente "por bolha"), é um algoritmo de ordenação dos mais simples. A ideia é percorrer o vector diversas vezes, e a cada passagem fazer flutuar para o topo o maior elemento da sequência. Essa movimentação lembra a forma como as bolhas em um tanque de água procuram seu próprio nível, e disso vem o nome do algoritmo.

> No melhor caso, o algoritmo executa **n** operações relevantes, onde **n** representa o número de elementos do vector. No pior caso, são feitas **n^2** operações. A complexidade desse algoritmo é de ordem quadrática. Por isso, ele não é recomendado para programas que precisem de velocidade e operem com quantidade elevada de dados 

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Bubble_sort)

Veja o exemplo, muito bem feito, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/lyZQPjUT5B4/0.jpg)](https://youtu.be/lyZQPjUT5B4)

__________

### **Cocktail Sort**

 > Cocktail sort, também conhecido como Shaker Sort, bubble sort bidirecional (que também pode se referir a uma variante do selection sort), ripple sort, shuttle sort ou happy hour sort, é uma variação do bubble sort que é tanto um algoritmo de ordenação estável quanto uma ordenação por comparação. O algoritmo difere do bubble sort pelo fato de ordenar em ambas as direções em cada passagem através da lista. Este algoritmo de ordenação é apenas ligeiramente mais difícil de implementar do que o bubble sort.

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Cocktail_sort)

Veja o exemplo, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/njClLBoEbfI/0.jpg)](https://youtu.be/njClLBoEbfI)

__________

### **Comb Sort**

 > O algoritmo Comb sort é um algoritmo de ordenação relativamente simples, e faz parte da família de algoritmos de ordenação por troca. Foi desenvolvido em 1980 por Wlodzimierz Dobosiewicz. Mais tarde, foi redescoberto e popularizado por Stephen Lacey e Richard Box em um artigo publicado na revista Byte em Abril de 1991. O Comb sort melhora o Bubble sort, e rivaliza com algoritmos como o Quicksort. A ideia básica é eliminar as tartarugas ou pequenos valores próximos do final da lista, já que em um bubble sort estes retardam a classificação tremendamente.

 > Na Bubble sort, quando quaisquer dois elementos são comparados, eles sempre têm um gap (distância um do outro) de 1. A ideia básica do Comb sort é que a diferença pode ser muito mais do que um.

> O gap (intervalo) começa como o comprimento da lista a ser ordenada dividida pelo fator de encolhimento (em geral 1,3), e a lista é ordenada com este valor (arredondado para um inteiro se for necessário) para o gap. Então, a diferença é dividida pelo fator de encolhimento novamente, a lista é ordenada com este novo gap, e o processo se repete até que a diferença seja de 1. Neste ponto, o Comb sort continua usando um espaço de 1 até que a lista esteja totalmente ordenada. A fase final da classificação é, portanto, equivalente a um bubble sort, mas desta vez a maioria dos elementos "tartarugas" já foram tratados, assim o bubble sort será eficiente

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Comb_sort)

Veja o exemplo, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/ob49RukGnAw/0.jpg)](https://youtu.be/ob49RukGnAw)

__________

### **Gnome Sort**

 > Algoritmo similiar ao Insertion sort com a diferença que o Gnome sort leva um elemento para sua posição correta, com uma seqüencia grande de trocas assim como o Bubble sort

> O algoritmo percorre o vetor comparando seus elementos dois a dois, assim que ele encontra um elemento que está na posição incorreta, ou seja, um número maior antes de um menor, ele troca a posição dos elementos, e volta com este elemento até que encontre o seu respectivo lugar.

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Gnome_sort)

Veja o exemplo, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/bilT6hjyAjM/0.jpg)](https://youtu.be/bilT6hjyAjM)

__________

### **Heap Sort**

 > O algoritmo heapsort é um algoritmo de ordenação generalista, e faz parte da família de algoritmos de ordenação por seleção. Foi desenvolvido em 1964 por Robert W. Floyd e J.W.J Williams

> Tem um desempenho em tempo de execução muito bom em conjuntos ordenados aleatoriamente, tem um uso de memória bem comportado e o seu desempenho em pior cenário é praticamente igual ao desempenho em cenário médio. Alguns algoritmos de ordenação rápidos têm desempenhos espectacularmente ruins no pior cenário, quer em tempo de execução, quer no uso da memória. O heapsort trabalha no lugar e o tempo de execução em pior cenário para ordenar n elementos é de O (n lg n). Lê-se logaritmo (ou log) de "n" na base 2. Para valores de n, razoavelmente grandes, o termo log n é quase constante, de modo que o tempo de ordenação é quase linear com o número de itens a ordenar.

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Heapsort)

Veja o exemplo, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/Xw2D9aJRBY4/0.jpg)](https://youtu.be/Xw2D9aJRBY4)

__________

### **OddEven Sort**

 > O Odd-even sort é um algoritmo de ordenação relativamente simples. É um algoritmo de ordenação por comparação baseado no bubble sort com o qual compartilha muitas características. Ele funciona através da comparação de todos os pares indexados (ímpar, par) de elementos adjacentes na lista e, se um par está na ordem errada (o primeiro é maior do que o segundo), os elementos são trocados. O próximo passo repete isso para os pares indexados (par, ímpar) (de elementos adjacentes). Em seguida, ele alterna entre etapas de (ímpar, par) e (par, ímpar) até que a lista é ordenada. Pode ser pensado como a utilização de processadores paralelos, cada qual usando um BubbleSort, mas a partir de diferentes pontos na lista (todos os índices ímpares para a primeira etapa). Este algoritmo de ordenação é apenas ligeiramente mais difícil do que o bubble sort para implementar.

 [Referências - Wikipedia](https://pt.wikipedia.org/wiki/Odd-even_sort)

Veja o exemplo, vale a pena assistir.

[![Insertion sort Exemplo](https://img.youtube.com/vi/AYehFa-oKCA/0.jpg)](https://youtu.be/AYehFa-oKCA)

__________

**Juliano Tiago Rinaldi**